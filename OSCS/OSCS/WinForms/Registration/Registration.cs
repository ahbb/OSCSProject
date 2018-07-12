using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Web.Helpers;
using System.Net.Mail;
using System.Net;

namespace OSCS.WinForms.Registration
{
    public partial class Registration : Form
    {
        string connstring = "Data Source=localhost;Initial Catalog=oscs;Integrated Security=True; User ID=root;Password=root; SslMode=none";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        string query;
        string activation_code = Guid.NewGuid().ToString(); 

        public Registration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           //for emailing user
            string username = txtUsername.Text.ToString();
            string email = txtEmail.Text.ToString();

            //captcha (assumed verified)
            registerUser();
            //send email after registration
            sendMsg(username, email, activation_code);

            //redirect to activation page
            Activation activate = new Activation();
            activate.Show();
            this.Hide();
        }

        private void registerUser()
        {
            if (txtUsername.Text == "" | txtEmail.Text == "" | txtPassword.Text == "" | txtConfirmPassword.Text == "" | txtContactNo.Text == "")
            {
                lbCheck.Text = "Please fill up all fields!";
            }
            else if (txtPassword.Text != txtConfirmPassword.Text | !ValidatePassword(txtPassword.Text))
            {
                lbPassword.ForeColor = Color.Red;
            }
            else if (lbContactNo.Text.Length != 0 && txtContactNo.Text.Length !=0)
            {
                lbContactNo.ForeColor = Color.Red;
            }
            else if (lbEmail.ForeColor == Color.Red)
            {
                lbEmail.ForeColor = Color.Red;
            }
            else if (lbUsername.ForeColor == Color.Red)
            {
                lbUsername.ForeColor = Color.Red;
            }
            
            else
            {
                lbCheck.Text = "";
                conn = new MySqlConnection(connstring);
                conn.Open();

                string salt = Crypto.GenerateSalt();
                string hashedPassword = Crypto.HashPassword(txtPassword.Text + salt);
                query = "";
                query = "insert into oscs.user(username, password, email, contactNo, salt) values(@username, @password, @email, @contact, @salt)";

                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@contact", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@salt", salt);
                cmd.ExecuteReader();
                MessageBox.Show("Registration is successful");

                conn.Close();
            }

            string cs = "Data Source=localhost;Initial Catalog=oscs;Integrated Security=True; User ID=root;Password=root; SslMode=none";
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd2 = new MySqlCommand("select * from user where email = @email", con);
                con.Open();
                cmd2.Parameters.AddWithValue("@email", txtEmail.Text);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //check if user have activated account
                if(dt.Rows.Count != 0)
                {
                    //insert activation entry into database
                    String activationCode = Guid.NewGuid().ToString();
                    int userid = Convert.ToInt32(dt.Rows[0][0]);
                    MySqlCommand cmd3 = new MySqlCommand("insert into activation values(@userid, @activationCode)", con);
                    cmd3.Parameters.AddWithValue("@userid", userid);
                    cmd3.Parameters.AddWithValue("@activationCode", activation_code);
                    cmd3.ExecuteNonQuery();

                    //email activation link to user
                    //string toemailaddress = dt.Rows[0][3].ToString();
                    //string username = dt.Rows[0][1].ToString();
                    //string emailbody = "Hi, " + username + ",<br/><br/>Thank you for registering with us.<br/>One more step... <br/> Enter the code below to finish registration.<br/>" + activationCode + "<br/>Thank you, <br/>Team Chat Safety.";

                    //MailMessage passrecmail = new MailMessage("\"Chat Safety \" <oscsgrp3@gmail.com>", toemailaddress);
                    //passrecmail.Body = emailbody;
                    //passrecmail.IsBodyHtml = true;
                    //passrecmail.Subject = "  Activation";

                    //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25);
                    //smtp.Credentials = new NetworkCredential()
                    //{
                    //    UserName = "oscsgrp3@gmail.com",
                    //    Password = "Yuhuil123"
                    //};

                    //smtp.EnableSsl = true;
                    //smtp.Send(passrecmail);
                }
            }
        }

        public static void sendMsg(string Username, string Email, string activation_code)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 25;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("oscsgrp32018@gmail.com", "Yuhui123");

            MailMessage msg = new MailMessage();
            msg.Subject = "Hello " + Username  + "";
            msg.Body = "Hello " + Username + ", thank you for registering with us!</br>";
           
            msg.Body += "<tr>";
            msg.Body += "<td>Your Account Details are given below: </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Username: " + Username + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Activation Code: " + activation_code + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Please check your email for your activation link to start using your account!</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td></br></td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Thank you, </td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";
            msg.Body += "<td>Team Chat Safety.</td>";
            msg.Body += "</tr>";

            string toAddress = Email; //recipient email
            msg.To.Add(toAddress);

            string fromAddress = "\"Chat Safety \" <oscsgrp32018@gmail.com>";
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

        //input validation check for txtPassword
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 1)
            {
                lbPassword.Text = "Password not inputted";
                lbPassword.ForeColor = Color.Red;
            }
            else if (!ValidatePassword(txtPassword.Text))
            {
                lbPassword.Text = "Password must be at least 8 characters, with at least 1 number, 1 lowercase and 1 uppercase.";
                lbPassword.ForeColor = Color.Red;
            }
            else
            {
                lbPassword.Text = "";
            }
            
        }

        //input validation check for txtConfirmPassword
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text.Length < 1)
            {
                lbConfirmPassword.Text = "Confirm Password not inputted";
                lbConfirmPassword.ForeColor = Color.Red;
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
            {
                lbConfirmPassword.Text = "Password do not match";
                lbConfirmPassword.ForeColor = Color.Red;
            }
            else if (txtConfirmPassword.Text == txtPassword.Text)
            {
                lbConfirmPassword.Text = "";
            }
        }

        //input validation check for txtContactNo
        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            if (txtContactNo.Text.Length < 1)
            {
                lbContactNo.Text = "Phone number not inputted";
                lbContactNo.ForeColor = Color.Red;
            }
            else if(txtContactNo.Text.Length != 8 | Regex.IsMatch(txtContactNo.Text, "[^0-9]"))
            {
                lbContactNo.Text = "Please enter phone number with 8 digits";
                lbContactNo.ForeColor = Color.Red;
            }
            else if (!(txtContactNo.Text.StartsWith("8") | txtContactNo.Text.StartsWith("9")))
            {
                lbContactNo.Text = "Please enter phone number starting with 8 or 9";
                lbContactNo.ForeColor = Color.Red;
            }
            else if (txtContactNo.Text.Length == 8)
            {
                lbContactNo.Text = "";
            }
        }

        //input validation for txtUsername
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connstring);
            conn.Open();

            query = "";
            query = "select * from user where username = @username";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                lbUsername.Text = "Username already exist!";
                lbUsername.ForeColor = Color.Red;
            }
            else
            {
                lbUsername.Text = "Username ok!";
                lbUsername.ForeColor = Color.ForestGreen;
            }

            if (txtUsername.Text.Length < 1)
            {
                lbUsername.Text = "Username not inputted";
                lbUsername.ForeColor = Color.Red;
            }
        }

        //input validation for txtEmail
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            var regex = "^\\w+@[a-za-z_]+?\\.[a-za-z]{2,3}$";
            Match match = Regex.Match(txtEmail.Text, regex, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                lbEmail.Text = "Invalid email format.";
                lbEmail.ForeColor = Color.Red;
            }

            else if (txtEmail.Text.Length < 1)
            {
                lbEmail.Text = "Email not inputted";
                lbEmail.ForeColor = Color.Red;
            }
            else
            {
                conn = new MySqlConnection(connstring);
                conn.Open();
                query = "";
                query = "select * from user where email=@email";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    lbEmail.Text = "Email already exist! Please use another email.";
                    lbEmail.ForeColor = Color.Red;
                }
                else
                {
                    lbEmail.Text = "Email available!";
                    lbEmail.ForeColor = Color.ForestGreen;
                }
            }
        }

        public bool ValidatePassword(string password)
        {
            string patternPassword = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$";
            if (!string.IsNullOrEmpty(password))
            {
                if(!Regex.IsMatch(password, patternPassword))
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
