﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSCS.WinForms.Registration
{
    public partial class Activation : Form
    {
        string connstring = System.Configuration.ConfigurationManager.ConnectionStrings["oscs"].ToString();
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        DataTable dt = new DataTable();
        tDes des = new tDes();
        int uid;
        string username, email, query;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Activation()
        {
            InitializeComponent();
        }

        private void txtActivation_TextChanged(object sender, EventArgs e)
        {
            if (txtActivation.Text.Length < 1)
            {
                lbActivation.Text = "Activation code not inputted";
                lbActivation.ForeColor = Color.Red;
            }
            else
            {
                lbActivation.Text = "";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //redirect to login page
            this.Hide();
            Login.Login login = new Login.Login();
            login.ShowDialog();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Login login = new Login.Login();
            login.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtActivation.Text != null)
            {
                conn = new MySqlConnection(connstring);
                conn.Open();
                query = "";
                query = "select * from activation where activation_code = @activation_code";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@activation_code", txtActivation.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    uid = Convert.ToInt32(dt.Rows[0][0]);
                    using (MySqlConnection con = new MySqlConnection(connstring))
                    {
                        MySqlCommand cmd1 = new MySqlCommand("delete from activation where userID = @uid", con);
                        cmd1.Parameters.AddWithValue("@uid", uid);
                        con.Open();
                        cmd1.ExecuteNonQuery();

                        cmd1 = new MySqlCommand("update user set activated = 'true' where userID = @uid", con);
                        cmd1.Parameters.AddWithValue("@uid", uid);
                        cmd1.ExecuteNonQuery();

                        //retrieve user details
                        MySqlCommand cmd2 = new MySqlCommand("select username, email from user where userID = @uid", con);
                        cmd2.Parameters.AddWithValue("@uid", uid);
                        reader = cmd2.ExecuteReader();

                        while (reader.Read())
                        {
                            username = reader.GetString(reader.GetOrdinal("username"));
                            email = reader.GetString(reader.GetOrdinal("email"));
                        }

                        //send email
                        sendMsg(username, des.Decrypt(email));
                    }

                    log4net.GlobalContext.Properties["userID"] = uid;
                    log.Info("User successfully activated their account.");

                    //show user activation success
                    lbActivation.Text = "Activation success";
                    btnSubmit.Visible = false;
                    //redirect to login page
                    this.Hide();
                    Login.Login login = new Login.Login();
                    login.ShowDialog();
                }
                else
                {
                    lbActivation.Text = "Activation code is incorrect";
                    lbActivation.ForeColor = Color.Red;
                }
            }
        }

        public static void sendMsg(string username, string email)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("2018oscs@gmail.com", "Yuhui123");

            MailMessage msg = new MailMessage();
            msg.Subject = "Account Activated";
            msg.Body = "Hello " + username + ", your account have been activated!</br>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please contact us immediately if it is not done by you.</td></br>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Thank you, </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Team Chat Safety.</td>";
            msg.Body += "</tr>";

            string toAddress = email; //recipient email
            msg.To.Add(toAddress);

            string fromAddress = "\"Chat Safety \" <2018oscs@gmail.com>";
            msg.From = new MailAddress(fromAddress);
            msg.IsBodyHtml = true;

            try
            {
                smtp.Send(msg);
            }
            catch
            {
                throw;
            }
        }
    }
}
