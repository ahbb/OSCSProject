﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using log4net;
using OSCS.WinForms.Admin;
using OSCS.WinForms.Registration;
using System.Web.Helpers;
using System.Net.Mail;
using System.Net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace OSCS.WinForms.Login
{
    public partial class Login : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        public string Username { get; set; }
        public string Password { get; set; }
        string salt, status, email, activated;
        int userID, counter;
        Boolean verify = false; //To verify password
        tDes des = new tDes();

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //redirect to activation page
            this.Hide();
            Activation activation = new Activation();
            activation.ShowDialog();
        }

        private void UnlockAccountButton_Click(object sender, EventArgs e)
        {
            UnlockAccount unlockAccount = new UnlockAccount();
            this.Hide();
            unlockAccount.ShowDialog();
        }

        private void ForgetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.ShowDialog();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration.Registration registration = new Registration.Registration();
            registration.ShowDialog();
        }

        private void ToLoginOTPButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //Login
            String cs = System.Configuration.ConfigurationManager.ConnectionStrings["oscs"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(cs);

            if (string.IsNullOrWhiteSpace(username.Text))
            {
                usernameWarning.Text = "Please input a username!";
                usernameWarning.ForeColor = System.Drawing.Color.Red;
                passwordWarning.Text = "";
                loginWarning.Text = "";

                if (string.IsNullOrWhiteSpace(password.Text))
                {
                    passwordWarning.Text = "Please input a password!";
                    passwordWarning.ForeColor = System.Drawing.Color.Red;
                }
            }

            else if (string.IsNullOrWhiteSpace(password.Text))
            {
                passwordWarning.Text = "Please input a password!";
                passwordWarning.ForeColor = System.Drawing.Color.Red;
                usernameWarning.Text = "";
                loginWarning.Text = "";
            }

            else
            {
                usernameWarning.Text = "";
                passwordWarning.Text = "";

                try
                {
                    using (MySqlCommand mainCommand = new MySqlCommand("SELECT * FROM oscs.user WHERE username=@username", conn))
                    {
                        conn.Open();
                        mainCommand.Parameters.AddWithValue("@username", username.Text); 
                        reader = mainCommand.ExecuteReader();

                        while (reader.HasRows && reader.Read())
                        {
                            userID = reader.GetInt32(reader.GetOrdinal("userID"));
                            Username = reader.GetString(reader.GetOrdinal("username"));
                            Password = reader.GetString(reader.GetOrdinal("password"));
                            email = des.Decrypt(reader.GetString(reader.GetOrdinal("email")));
                            salt = reader.GetString(reader.GetOrdinal("salt"));
                            status = reader.GetString(reader.GetOrdinal("status"));
                            counter = reader.GetInt32(reader.GetOrdinal("counter"));
                            activated = reader.GetString(reader.GetOrdinal("activated"));

                            if (Crypto.VerifyHashedPassword(Password, password.Text + salt)) //verify hashed password
                            {
                                verify = true;
                            }
                            else
                            {
                                verify = false;
                            }
                        }

                        //Session to User Login OTP Page and Admin Logs
                        if (reader.HasRows && status == "green" && verify == true && counter < 3)
                        {
                            if (username.Text == "OCPAdmin") //Have to manually set all data (activated = true) for Admin in first row of user table
                            {
                                conn.Close();
                                LoginInfo.UserID = userID;
                                LoginInfo.UserName = Username;
                                this.Hide();

                                //To Admin viewing of User Logs
                                UserLogs userLogs = new UserLogs();
                                userLogs.ShowDialog();
                            }

                            else
                            {
                                using (MySqlConnection con = new MySqlConnection(cs))
                                {
                                    conn.Close();
                                    conn.Open();
                                    LoginInfo.UserID = userID;
                                    LoginInfo.UserName = Username;

                                    MySqlCommand cmd2 = new MySqlCommand("select * from oscs.activation where userID=@userID", con);
                                    con.Open();
                                    cmd2.Parameters.AddWithValue("@userID", userID);

                                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd2);
                                    sda.Fill(dt);

                                    if (dt.Rows.Count == 0)
                                    {
                                        LoginInfo.UserID = userID;
                                        LoginInfo.UserName = Username;

                                        log4net.GlobalContext.Properties["userID"] = userID;
                                        log.Info("User successfully entered username and password.");
                                        conn.Close();
                                        this.Hide();
                                        LoginOTP loginOTP = new LoginOTP();
                                        loginOTP.ShowDialog();
                                    }

                                    else // If activation code for specific user still exists in activation table
                                    {
                                        loginWarning.Text = "You have not activated your account. \nPlease check your email for the activation link.";
                                        loginWarning.ForeColor = System.Drawing.Color.Red;
                                    }
                                    con.Close();
                                }
                            }
                        }
                        
                        else if (reader.HasRows && status == "red" && verify == true)
                        {
                            if (activated == "true")
                            {
                                loginWarning.Text = "You have been locked out due to too many failed login attempts. \nPlease check your email to recover your account.";
                                username.Text = string.Empty;
                                password.Text = string.Empty;
                            }
                        }

                        else
                        {
                            //Invalid Username/Password
                            using (MySqlConnection conn = new MySqlConnection(cs))
                            {
                                conn.Close();
                                conn.Open();
                                string selectQuery = "SELECT userID, counter, activated FROM user WHERE username=@username";
                                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                                cmd.Parameters.AddWithValue("@username", username.Text);
                                reader = cmd.ExecuteReader();
                                if (reader.HasRows && reader.Read())
                                {
                                    if (activated == "true")
                                    {
                                        int logUserID = reader.GetInt32(reader.GetOrdinal("userID"));
                                        log4net.GlobalContext.Properties["userID"] = logUserID;
                                        log.Error("Authentication failed - User entered wrong password.");
                                        int counter = reader.GetInt32(reader.GetOrdinal("counter"));
                                        reader.Close();
                                        counter += 1;
                                        if (counter >= 3)
                                        {
                                            string query = "UPDATE user SET status=@status,counter=@counter WHERE userID=@userID";
                                            MySqlCommand cmdd = new MySqlCommand(query, conn);
                                            cmdd.Parameters.AddWithValue("@status", "red");
                                            cmdd.Parameters.AddWithValue("@userID", logUserID);
                                            cmdd.Parameters.AddWithValue("@counter", counter);
                                            cmdd.ExecuteNonQuery();

                                            log4net.GlobalContext.Properties["userID"] = logUserID;
                                            log.Warn("An unsuccessful attempt was made to access the locked account.");

                                            username.Text = string.Empty;
                                            password.Text = string.Empty;
                                            loginWarning.Text = "The account that you are trying to access has been locked. \nAn email with relevant information has been sent to account owner.";

                                            //checking whether reset password email has been sent
                                            string selectQuery2 = "SELECT userID FROM resetpasswordrequests WHERE userID=@userID";
                                            MySqlCommand cmd2 = new MySqlCommand(selectQuery2, conn);
                                            cmd2.Parameters.AddWithValue("@userID", userID);
                                            reader = cmd2.ExecuteReader();

                                            //email not sent yet
                                            if (!reader.Read() && !reader.HasRows) 
                                            {
                                                String resetCode = Guid.NewGuid().ToString();
                                                string insertQuery = "INSERT INTO resetpasswordrequests (ID,userID) VALUES (@ID,@userID)";
                                                MySqlCommand cmd3 = new MySqlCommand(insertQuery, conn);
                                                cmd3.Parameters.AddWithValue("@ID", resetCode);
                                                cmd3.Parameters.AddWithValue("@userID", userID);
                                                //cmd3.Parameters.AddWithValue("@resetRequestDateTime", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                                                reader.Close();
                                                cmd3.ExecuteNonQuery();

                                                //SEND RESET LINK TO EMAIL
                                                String ToEmailAddress = email;
                                                String ToUserName = Username;
                                                String EmailBody = "Hi " + ToUserName + ",<br/><br/>Your account has been locked automatically due to multiple incorrect attempts during password input.<br/><br/>If this was not performed by you, someone else may be trying to gain access to your account.<br/><br/>Please use the following Reset Code: "+ resetCode + " to set a new strong password.<br/><br/>Thank you, <br/>Team Chat Safety.";
                                                MailMessage PassRecMail = new MailMessage("\"Chat Security \" <2018oscs@gmail.com>", ToEmailAddress);
                                                PassRecMail.Body = EmailBody;
                                                PassRecMail.IsBodyHtml = true;
                                                PassRecMail.Subject = "Unlock Account and Reset Password";

                                                SmtpClient SMTP = new SmtpClient("smtp.gmail.com", 25);
                                                SMTP.Credentials = new NetworkCredential()
                                                {
                                                    UserName = "2018oscs@gmail.com",
                                                    Password = "Yuhui123"
                                                };

                                                SMTP.EnableSsl = true;
                                                SMTP.Send(PassRecMail);
                                            }
                                        } //if counter >= 3 end

                                        else
                                        {
                                            string query = "UPDATE user SET counter=@counter where userID=@userID";
                                            MySqlCommand cmdd = new MySqlCommand(query, conn);
                                            cmdd.Parameters.AddWithValue("@counter", counter);
                                            cmdd.Parameters.AddWithValue("@userID", logUserID);
                                            cmdd.ExecuteNonQuery();

                                            username.Text = string.Empty;
                                            password.Text = string.Empty;
                                            loginWarning.Text = "Invalid user or password! \nPlease input the correct username or password.";
                                            loginWarning.ForeColor = System.Drawing.Color.Red;
                                        }
                                    }
                                    else if (activated == "false")
                                    {
                                        username.Text = string.Empty;
                                        password.Text = string.Empty;
                                        loginWarning.Text = "This account has not been activated yet. \nAn activation link has been sent to the email associated with account.";
                                        loginWarning.ForeColor = System.Drawing.Color.Red;
                                    }
                                }
                                else
                                {
                                    username.Text = string.Empty;
                                    password.Text = string.Empty;
                                    loginWarning.Text = "Invalid user or password! \nPlease input the correct username or password.";
                                    loginWarning.ForeColor = System.Drawing.Color.Red;
                                }
                                conn.Close();
                            }
                        }
                        conn.Close();
                        reader.Close();
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Error processing user input");
                }
            }
        }
    }
}
