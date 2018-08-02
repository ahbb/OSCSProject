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
using nClam;
using VirusTotalNET;
using VirusTotalNET.Objects;
using VirusTotalNET.ResponseCodes;
using VirusTotalNET.Results;
using OSCS.WinForms.Login;

//insert code to scan attachments and links in FiddlerApplication_BeforeRequest method to manipulate response when user clicks on a hyperlink or attachment
//click yes to install the certificate when prompted after start is clicked - so ssl traffic can be decrypted and shown. Will be asked to delete the certificate after clicking stop button, click yes 

namespace OSCS.WinForms.Fiddler
{
    public partial class FiddlerCapture : Form
    {
        private const string Separator = "------------------------------------------------------------------";
        //private static string ScanUrl = "http://www.sanagustinturismo.co/Facebook/"; 1 true
        private static string ScanUrl = "";
        static int userID;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
            FiddlerApplication.BeforeRequest -= FiddlerApplication_BeforeRequest;
            FiddlerApplication.AfterSessionComplete -= FiddlerApplication_AfterSessionComplete;

            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();
        }

        //refresh every 20 seconds
        private void timer_Tick(object sender, EventArgs e)
        {
            //txtCapture.Text = "";
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

        
        //sess.fullUrl = whole url after GET/POST
        //sess.oRequest.headers.toString() = the GET/POST paragraph 
        private void FiddlerApplication_BeforeRequest(Session sess)
        {
            //once user clicks on an attachment in Discord, a HTTP request with GET <sess.fullUrl> will be captured. sess.fullUrl will contain "attachment" and will have an extension. No referer = no redirection from site to site (eg. clicking on links after google search)

            if (sess.oRequest.headers.ToString().ToUpper().Contains("GET") && sess.fullUrl.Contains("attachment") && !sess.oRequest.headers.ToString().Contains("Referer:") && Path.HasExtension(sess.fullUrl) && !sess.oRequest.headers.ToString().ToUpper().Contains("POST"))
            {
                //using AMSI - if no virus detected, use nClam to scan
                bool virusDetected = RunFileScan(sess.fullUrl);
                if (virusDetected == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Possibly malicious file detected!\nDownload blocked!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                    log4net.GlobalContext.Properties["userID"] = userID;
                    log.Warn("User downloaded an attachment from Discord where virus(es) were detected on it.");

                    //change to MessageBoxButtons.YesNo to display yes and no buttons. use if (dialogResult==DialogResult.Yes) for when user clicks yes, and if (dialogResult == DialogResult.No) for when user clicks no. 
                    //If checking for what user clicked, ensure that sess.utilCreateResponseandBypassServer(); is only in if (dialogResult==DialogResult.No) (user choose not to download/access) so return can be carried out in if (dialogResult == DialogResult.Yes)

                    sess.utilCreateResponseAndBypassServer(); //so server will be bypassed and download will not occur, the code below will run instead
                    sess.oResponse.headers.SetStatus(307, "Redirect");
                        sess.oResponse["Cache-Control"] = "nocache";
                        sess.utilSetResponseBody("<html><body>Possibly malicious file detected. Download blocked.</body></html>");
                        return;
                }

                //using nClam
                else if (virusDetected == false)
                {
                    try
                    {
                        Stop();

                        byte[] filebytes = GetFileBytes(sess.fullUrl);
                        var clam = new ClamClient("localhost", 3310);

                        //using Task.Run async to call await clam method so FiddlerApplication_BeforeRequest does not have to be async
                        var clamTask = Task.Run (async () => await clam.SendAndScanFileAsync(filebytes));
                        clamTask.Wait(); //to get the results of scan

                        Start();

                        var scanResult = clamTask.Result;
                        if (scanResult.ToString().Contains("FOUND")) //virus found
                        {
                           DialogResult dialogResult2 = MessageBox.Show("Possibly malicious file detected! Virus Name: " + scanResult.InfectedFiles.First().VirusName + "\nDownload blocked!", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

                            sess.utilCreateResponseAndBypassServer();
                            sess.oResponse.headers.SetStatus(307, "Redirect");
                                sess.oResponse["Cache-Control"] = "nocache";
                                sess.utilSetResponseBody("<html><body>Possibly malicious file detected. Download blocked.</body></html>");
                            log4net.GlobalContext.Properties["userID"] = userID;
                            log.Warn("User downloaded an attachment from Discord where virus(es) were detected on it.");

                        }

                        else if (scanResult.ToString().Contains("OK")) //no virus found
                        {
                            Debug.Print("File is clean!");
                        }
                        else
                        {
                            Debug.Print("Error!");
                        }
                    }

                    //if nClam not running, download will not occur
                    catch (Exception e)
                    {
                        sess.utilCreateResponseAndBypassServer();
                        sess.oResponse.headers.SetStatus(307, "Redirect");
                        sess.oResponse["Cache-Control"] = "nocache";
                        sess.utilSetResponseBody("<html><body>Sorry, the ClamWin Services may not running on your computer so we are not able to confirm whether the file you are trying to download is malicious or not.</body></html>");
                        Debug.Print(e.ToString()+"\nClamWin Services not running.");
                    }

                }
            }
            
            //when user clicks on a hyperlink
           else if (sess.oRequest.headers.ToString().ToUpper().Contains("GET") && !sess.oRequest.headers.ToString().Contains("Referer:") && !sess.oRequest.headers.ToString().ToUpper().Contains("POST") && sess.oRequest.headers.ToString().Contains("Accept-Encoding:") && sess.oRequest.headers.ToString().Contains("Accept:") && sess.oRequest.headers.ToString().Contains("Accept-Language:")) 
            {
                try
                {
                    ScanUrl = sess.fullUrl;
                    var urlTask = Task.Run(async () => await UrlCheck(sess));
                    urlTask.Wait();
                }
                catch (Exception e)
                {
                    sess.utilCreateResponseAndBypassServer();
                    sess.oResponse.headers.SetStatus(307, "Redirect");
                    sess.oResponse["Cache-Control"] = "nocache";
                    sess.utilSetResponseBody("<html><body>Virus Total limit exceeded! Please try again later.</body></html>");
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
        private bool RunFileScan(string fileurl)
        {
            bool hasVirus = false; //if there is an error with user's anti-virus, hasVirus will return false.
            try
            {
                Stop();
                byte[] filebytes = GetFileBytes(fileurl);
                var scanner = new MalwareScanner();
                var result = scanner.HasVirus(filebytes, fileurl);
                Start();
                string virusDetected = result.ToString();
                if (virusDetected.Contains("True"))
                {
                    hasVirus = true;
                }
                else
                {
                    hasVirus = false;
                }
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
            return hasVirus;
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
            if (Login.LoginInfo.UserID == 0)
            {
                this.Hide();
                Login.Login login = new Login.Login();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                userID = Login.LoginInfo.UserID;
                UpdateButtonStatus();
            }
        }

        private void FiddlerCapture_FormClosed(object sender, FormClosedEventArgs e)
        {
            UninstallCertificate();
            Stop();
        }


        //using virustotal to scan urls
        private static async Task UrlCheck(Session sess)
        {
            //only can scan 4 per minute (public)
            VirusTotal virusTotal = new VirusTotal("29665c8e3e1da563a81a1a2c8d9200e5ad3cbd4297d81fdea1a7d21fa7fb1919");
            int counter = 0;
            //Use HTTPS instead of HTTP
            virusTotal.UseTLS = true;

            UrlReport urlReport = await virusTotal.GetUrlReportAsync(ScanUrl);
            Debug.Print(ScanUrl);

            if (urlReport.ResponseCode == UrlReportResponseCode.Present)
            {
                counter = urlReport.Positives; //number of anti-virus vendors that detected this link as malicious

                //UrlScanResult urlResult = await virusTotal.ScanUrlAsync(ScanUrl);
                //PrintScan(urlResult);
                //counter = PrintScan(urlReport); 

                //if 3 or more detects this link as malicious
                if (counter >= 3)
                {
                    DialogResult dialogResult = MessageBox.Show("Possibly malicious link detected!\nWebsite blocked!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

                    sess.utilCreateResponseAndBypassServer();
                    sess.oResponse.headers.SetStatus(307, "Redirect");
                    sess.oResponse["Cache-Control"] = "nocache";
                    sess.utilSetResponseBody("<html><body>Possibly malicious link detected. Access to website blocked.</body></html>");
                    log4net.GlobalContext.Properties["userID"] = userID;
                    log.Warn("User clicked on a hyperlink that lead to a confirmed malicious website.");
                    return;
                }
                else if (counter == 1 | counter == 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Possibly malicious link detected!\nWould you like to proceed to the page?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);

                    if (dialogResult == DialogResult.No)
                    {
                        sess.utilCreateResponseAndBypassServer();
                        sess.oResponse.headers.SetStatus(307, "Redirect");
                        sess.oResponse["Cache-Control"] = "nocache";
                        sess.utilSetResponseBody("<html><body>Possibly malicious link detected. Access to website blocked.</body></html>");
                        log4net.GlobalContext.Properties["userID"] = userID;
                        log.Warn("User clicked on a hyperlink that lead to a possible malicious website.");
                        return;
                    }
                }
            }

            //url report not present
            else
            {
                UrlScanResult urlResult = await virusTotal.ScanUrlAsync(ScanUrl);
                DialogResult dialogResult = MessageBox.Show("Link not scanned before! \nWould you like to proceed to the page?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);

                if(dialogResult == DialogResult.No)
                {
                    sess.utilCreateResponseAndBypassServer();
                    sess.oResponse.headers.SetStatus(307, "Redirect");
                    sess.oResponse["Cache-Control"] = "nocache";
                    sess.utilSetResponseBody("<html><body>We have sent the link to Virus Total. Please try again later.</body></html>");
                    Debug.Print("No url report found.");
                    return;
                }
            }
        }


        private static int PrintScan(UrlReport urlReport)
        {
            //Console.WriteLine("Scan ID: " + urlReport.ScanId);
            //Console.WriteLine("Message: " + urlReport.VerboseMsg);
            int counter = 0;

            if (urlReport.ResponseCode == UrlReportResponseCode.Present)
            {
                foreach (KeyValuePair<string, UrlScanEngine> scan in urlReport.Scans)
                {
                    //Console.WriteLine("{0,-25} Detected: {1}", scan.Key, scan.Value.Detected);
                    if (scan.Value.Detected == true)
                    {
                        counter++;
                    }
                }
            }
            return counter;
            //Console.WriteLine();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Stop();
            UninstallCertificate();
            Login.LoginInfo.UserID = 0;
            LoginInfo.UserName = "";
            this.Hide();
            Login.Login login = new Login.Login();
            login.ShowDialog();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Stop();
            UninstallCertificate();
            this.Hide();
            Login.Homepage homepage = new Login.Homepage();
            homepage.ShowDialog();
        }
    }
}
