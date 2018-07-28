using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusTotalNET;
using VirusTotalNET.Objects;
using VirusTotalNET.ResponseCodes;
using VirusTotalNET.Results;
using VirusTotalNET.Exceptions;
using System.Diagnostics;

namespace OSCS.WinForms.FileVirusChecker
{
    public partial class FileVirusChecker : Form
    {
        static byte[] ScanFile;

        public FileVirusChecker()
        {
            InitializeComponent();
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                fileName.Text = openFileDialog.FileName;
                ScanFile = File.ReadAllBytes(openFileDialog.FileName);
                //ScanFile = Encoding.ASCII.GetBytes(@"X5O!P%@AP[4\PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*");
            }
        }

        private async Task FileCheck()
        {
            if (ScanFile != null && ScanFile.Length > 0)
            {
                //only can scan 4 per minute (public)
                VirusTotal virusTotal = new VirusTotal("aaac0a1ce9f703c53077458ea6b54b0be48c7daae133ca4e7d37e08cf59be4e3");

                //Use HTTPS instead of HTTP
                virusTotal.UseTLS = true;

                FileReport fileReport = await virusTotal.GetFileReportAsync(ScanFile);

                bool hasFileBeenScannedBefore = fileReport.ResponseCode == FileReportResponseCode.Present;

                if (hasFileBeenScannedBefore == true) //file report present, so report can be retrieved

                {
                    int counter = fileReport.Positives; //Number of anti-virus vendors that had detected this file to be malicious

                    //ScanResult fileResult = await virusTotal.ScanFileAsync(ScanFile, "EICAR.txt");
                    //counter = PrintScan(fileReport); 

                    //if there are 3 or more hits by anti-virus vendors  
                    if (counter >= 3)
                    {
                        result.Text = "Virus has been detected on this file! Do not open it and delete it immediately!";
                        result.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        result.Text = "The file is safe. No viruses were detected during scan.";
                        result.ForeColor = System.Drawing.Color.Green;
                    }

                    //displaying results in grid view
                    foreach (KeyValuePair<string, ScanEngine> scan in fileReport.Scans)
                    {
                        dataGridView1.Rows.Add(scan.Key, scan.Value.Detected);
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (Convert.ToString(row.Cells[1].Value) == "True")
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                                row.DefaultCellStyle.ForeColor = Color.White;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.Green;
                                row.DefaultCellStyle.ForeColor = Color.Yellow;
                            }

                        }
                    }

                }

                else
                {
                    ScanResult fileResult = await virusTotal.ScanFileAsync(ScanFile, "EICAR.txt");
                    result.Text = "There are no reports retrieved for the file that you have just uploaded. We have sent the file to Virus Total for a scan.";
                }
            }
            else
            {
                result.Text = "Please choose a file before starting the virus scan!";
                result.ForeColor = System.Drawing.Color.Red;
            }
        }

        private static int PrintScan(FileReport fileReport)
        {
            int counter = 0;
            if (fileReport.ResponseCode == FileReportResponseCode.Present)
            {
                foreach (KeyValuePair<string, ScanEngine> scan in fileReport.Scans)
                {
                    //Console.WriteLine("{0,-25} Detected: {1}", scan.Key, scan.Value.Detected);
                    if (scan.Value.Detected == true)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private async void scanFile_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                await FileCheck();
            }
            catch (Exception)
            {
                result.Text = "You have reached a maximum of 4 scans in a minute! Please wait before proceeding with next scan.";
                result.ForeColor = System.Drawing.Color.Red;
                //throw new RateLimitException("You have reached the 4 requests pr. min. limit of VirusTotal");
            }
        }
    }
}
