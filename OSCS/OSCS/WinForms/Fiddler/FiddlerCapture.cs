using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;
using MalwareScan.AMSI;

namespace OSCS.WinForms.Fiddler
{
    public partial class FiddlerCapture : Form
    {
        private const string Separator = "------------------------------------------------------------------";

        public FiddlerCapture()
        {
            InitializeComponent();
        }

        private void FiddlerApplication_AfterSessionComplete(Session sess)
        {
            // Ignore HTTPS connect requests
            if (sess.RequestMethod == "CONNECT")
                return;

            /*if (CaptureConfiguration.ProcessId > 0)
            {
                if (sess.LocalProcessID != 0 && sess.LocalProcessID != CaptureConfiguration.ProcessId)
                    return;
            }

            if (!string.IsNullOrEmpty(CaptureConfiguration.CaptureDomain))
            {
                if (sess.hostname.ToLower() != CaptureConfiguration.CaptureDomain.Trim().ToLower())
                    return;
            }

            if (CaptureConfiguration.IgnoreResources)
            {
                string url = sess.fullUrl.ToLower();

                var extensions = CaptureConfiguration.ExtensionFilterExclusions;
                foreach (var ext in extensions)
                {
                    if (url.Contains(ext))
                        return;
                }

                var filters = CaptureConfiguration.UrlFilterExclusions;
                foreach (var urlFilter in filters)
                {
                    if (url.Contains(urlFilter))
                        return;
                }
            }*/

            if (sess == null || sess.oRequest == null || sess.oRequest.headers == null)
                return;

            string headers = sess.oRequest.headers.ToString();
            var reqBody = Encoding.UTF8.GetString(sess.RequestBody);

            // if you wanted to capture the response
            //string respHeaders = session.oResponse.headers.ToString();
            //var respBody = Encoding.UTF8.GetString(session.ResponseBody);

            // replace the HTTP line to inject full URL
            //printing traffic 
            string firstLine = sess.RequestMethod + " " + sess.fullUrl + " " + sess.oRequest.headers.HTTPVersion;
            int at = headers.IndexOf("\r\n");
            if (at < 0)
                return;
            headers = firstLine + "\r\n" + headers.Substring(at + 1);

            string output = headers + "\r\n" +
                            (!string.IsNullOrEmpty(reqBody) ? reqBody + "\r\n" : string.Empty) +
                            Separator + "\r\n\r\n";

            // must marshal to UI thread
            BeginInvoke(new Action<string>((text) =>
            {
                txtCapture.AppendText(text);
                UpdateButtonStatus();
            }), output);

        }

        void Start()
        {
            /*if (tbIgnoreResources.Checked)
                CaptureConfiguration.IgnoreResources = true;
            else
                CaptureConfiguration.IgnoreResources = false;

            string strProcId = txtProcessId.Text;
            if (strProcId.Contains('-'))
                strProcId = strProcId.Substring(strProcId.IndexOf('-') + 1).Trim();

            strProcId = strProcId.Trim();

            int procId = 0;
            if (!string.IsNullOrEmpty(strProcId))
            {
                if (!int.TryParse(strProcId, out procId))
                    procId = 0;
            }
            //CaptureConfiguration.ProcessId = procId;
            //CaptureConfiguration.CaptureDomain = txtCaptureDomain.Text;*/

            Timer timer = new Timer();
            timer.Interval = (20 * 1000); // 20 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            FiddlerApplication.BeforeRequest += FiddlerApplication_BeforeRequest;
            FiddlerApplication.AfterSessionComplete += FiddlerApplication_AfterSessionComplete;
            FiddlerApplication.Startup(8888, true, true, true);
        }

        void Stop()
        {
            FiddlerApplication.AfterSessionComplete -= FiddlerApplication_AfterSessionComplete;
            FiddlerApplication.BeforeRequest -= FiddlerApplication_BeforeRequest;

            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txtCapture.Text = "";
        }

        public static bool InstallCertificate()
        {
            if (!CertMaker.rootCertExists())
            {
                if (!CertMaker.createRootCert())
                    return false;

                if (!CertMaker.trustRootCert())
                    return false;
            }

            return true;
        }

        public static bool UninstallCertificate()
        {
            if (CertMaker.rootCertExists())
            {
                if (!CertMaker.removeFiddlerGeneratedCerts(true))
                    return false;
            }
            return true;
        }

        private void ButtonHandler(object sender, EventArgs e)
        {
            if (sender == tbCapture)
            {
                InstallCertificate();
                Start();
            }
            else if (sender == tbStop)
            {
                UninstallCertificate();
                Stop();
            }
            else if (sender == tbSave)
            {
                var diag = new SaveFileDialog()
                {
                    AutoUpgradeEnabled = true,
                    CheckPathExists = true,
                    DefaultExt = "txt",
                    Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*",
                    OverwritePrompt = true,
                    Title = "Save Fiddler Capture File",
                    RestoreDirectory = true
                };
                var res = diag.ShowDialog();

                if (res == DialogResult.OK)
                {
                    if (File.Exists(diag.FileName))
                        File.Delete(diag.FileName);

                    File.WriteAllText(diag.FileName, txtCapture.Text);

                }
            }
            else if (sender == tbClear)
            {
                txtCapture.Text = string.Empty;
            }
            /*else if (sender == btnInstallSslCert)
            {
                Cursor = Cursors.WaitCursor;
                InstallCertificate();
                Cursor = Cursors.Default;
            }
            else if (sender == btnUninstallSslCert)
                UninstallCertificate();*/

            UpdateButtonStatus();
        }

        private void FiddlerApplication_BeforeRequest(Session sess)
        {
            //redirecting for discord attachments
            if (sess.fullUrl.Contains("attachment"))
            {
                //sess.utilCreateResponseAndBypassServer();
                //sess.oResponse.headers.SetStatus(307, "Redirect");
                //sess.oResponse["Cache-Control"] = "nocache";
                //sess.utilSetResponseBody("<html><body>Malicious file detected. Download blocked.</body></html>");

                //using AMSI, if no virus detected use nClam to scan
                bool virusDetected = RunFileScan(sess.fullUrl);
                if (virusDetected == true)
                {
                    sess.utilCreateResponseAndBypassServer();
                    MessageBox.Show("Possibly malicious file detected! Download blocked!");
                    return;
                }
            }
        }

        //method uses WebClient.DownloadData to get bytes of file from the url
        private byte[] GetFileBytes(string urlDownload)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;

            using (WebClient client = new WebClient())
            {
                byte[] filebytes = client.DownloadData(urlDownload);
                client.Dispose();
                Debug.Print(Encoding.ASCII.GetString(filebytes));
                return filebytes;
            }
        }

        //method calls getFileBytes method to get bytes from the url. Then AMSI will be used to scan the bytes. If got virus, hasVirus returns true
        private bool RunFileScan(string url) //sess.fullUrl
        {
            bool hasVirus = true;
            Stop();
            byte[] filebytes = GetFileBytes(url);
            var scanner = new MalwareScanner();
            var result = scanner.HasVirus(filebytes, url);
            Start();
            string virusDetected = result.ToString();
            if (virusDetected == "True") 
            {
                hasVirus = true;
            }
            else
            {
                hasVirus = false;
            }
            return hasVirus;
        }

        private void FiddlerCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            UninstallCertificate();
            Stop();
        }

        public void UpdateButtonStatus()
        {
            tbCapture.Enabled = !FiddlerApplication.IsStarted();
            tbStop.Enabled = !tbCapture.Enabled;
            tbSave.Enabled = txtCapture.Text.Length > 0;
            tbClear.Enabled = tbSave.Enabled;

            //CaptureConfiguration.IgnoreResources = tbIgnoreResources.Checked;
        }

        private void FiddlerCapture_Load(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
    }
}
