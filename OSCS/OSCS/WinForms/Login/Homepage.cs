﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSCS.WinForms.Fiddler;
using MySql.Data.MySqlClient;


namespace OSCS.WinForms.Login
{
    public partial class Homepage : Form
    {
        int userID;
        string username;

        public Homepage()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginInfo.UserID = 0;
            LoginInfo.UserName = "";
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["oscs"].ConnectionString;
            MySqlConnection MyConnection = new MySqlConnection(cs);
            MyConnection.Open();

            userID = LoginInfo.UserID;
            username = LoginInfo.UserName;

            TitleLabel.Text = "Welcome, " + username;
        }

        private void FiddlerCapturing_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fiddler.FiddlerCapture fiddlercapture = new FiddlerCapture();
            fiddlercapture.ShowDialog();
        }

        private void FileVirusScanner_Click(object sender, EventArgs e)
        {
            this.Hide();
            FileVirusChecker.FileVirusChecker fileviruschecker = new FileVirusChecker.FileVirusChecker();
            fileviruschecker.ShowDialog();
        }
    }
}
