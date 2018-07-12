using System;
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

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace OSCS.WinForms.Login
{
    public partial class Login : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        public string Username { get; set; }
        public string Password { get; set; }
        string salt, status, activationCode;
        int userID;
        Boolean verify = false; //To verify password

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Login()
        {
            InitializeComponent();
        }

        private void ForgetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.ShowDialog();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Registration registration = new Registration();
            //registration.ShowDialog();
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
                        mainCommand.Parameters.AddWithValue("@username", /*des.Encrypt*/username.Text); //Encryption of user details later
                        reader = mainCommand.ExecuteReader();

                        while (reader.HasRows && reader.Read())
                        {
                            userID = reader.GetInt32(reader.GetOrdinal("userID"));
                            Username = /*des.Decrypt*/(reader.GetString(reader.GetOrdinal("username")));
                            Password = reader.GetString(reader.GetOrdinal("password"));
                            salt = reader.GetString(reader.GetOrdinal("salt"));
                            status = reader.GetString(reader.GetOrdinal("status"));

                            if (Crypto.VerifyHashedPassword(Password, password.Text + salt)) //verify hashed password
                            {
                                verify = true;
                            }
                        }

                        //Session to User Login OTP Page and Admin HomePage
                        if (reader.HasRows && status == "green" && verify == true)
                        {
                            if (username.Text == "OCPAdmin")
                            {
                                conn.Close();
                                LoginInfo.UserID = userID;
                                LoginInfo.UserName = Username;
                                //log4net.GlobalContext.Properties["userID"] = userID;
                                //log.Info("Admin successfully signed in.");
                                this.Hide();
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

                                        /*string selectQuery = "SELECT userID from user WHERE username=@username";
                                        MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                                        cmd.Parameters.AddWithValue("@username", /*des.Encrypt(username.Text));
                                        reader = cmd.ExecuteReader();
                                        while (reader.HasRows && reader.Read())
                                        {
                                            int logUserID = reader.GetInt32(reader.GetOrdinal("userID"));*/
                                            log4net.GlobalContext.Properties["userID"] = userID;
                                            log.Info("User successfully entered username and password.");/*
                                        }
                                        reader.Close();
                                        cmd.ExecuteNonQuery();*/
                                        conn.Close();
                                        this.Hide();
                                        LoginOTP loginOTP = new LoginOTP();
                                        loginOTP.ShowDialog();
                                    }

                                    else //If-else for the dt.Rows.Count==0) //Verify label formatting later
                                    {
                                        loginWarning.Text = "You have not activated your account. \nPlease check your email for the activation link.";
                                    }
                                    con.Close();
                                }
                            }
                        }
                        
                        
                        else if (reader.HasRows && status == "red" && verify == true)
                        {
                            //LoginPanel.Visible = false;
                            //RecoverPanel.Visible = true;
                            loginWarning.Text = "You have been locked out due to too many failed login attempts. \nPlease check your email to recover your account.";
                            username.Text = string.Empty;
                            password.Text = string.Empty;
                        }

                        else
                        {
                            //Invalid username/Password
                            using (MySqlConnection conn = new MySqlConnection(cs))
                            {
                                conn.Close();
                                conn.Open();
                                string selectQuery = "SELECT userID, counter FROM user WHERE username=@username";
                                MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                                cmd.Parameters.AddWithValue("@username", /*des.Encrypt3*/(username.Text));
                                reader = cmd.ExecuteReader();
                                if (reader.HasRows && reader.Read())
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
                                        log.Warn("An attempt was made to access the locked account.");

                                        username.Text = string.Empty;
                                        password.Text = string.Empty;
                                        loginWarning.Text = "The account that you are trying to access has been locked. \nAn email with relevant information has been sent to account owner.";

                                        //checking whether email has been sent
                                        /*string selectQuery2 = "SELECT userID FROM resetpasswordrequests WHERE userID=@userID";
                                        MySqlCommand cmd2 = new MySqlCommand(selectQuery2, con);
                                        cmd2.Parameters.AddWithValue("@userID", id);
                                        reader = cmd2.ExecuteReader();
                                        if (!reader.Read() && !reader.HasRows) //email not sent yet
                                        {
                                            String resetCode = Guid.NewGuid().ToString();
                                            string insertQuery = "INSERT INTO resetpasswordrequests (ID,userID,resetRequestDateTime) VALUES (@ID,@userID,@resetRequestDateTime)";
                                            MySqlCommand cmd3 = new MySqlCommand(insertQuery, con);
                                            cmd3.Parameters.AddWithValue("@ID", resetCode);
                                            cmd3.Parameters.AddWithValue("@userID", id);
                                            cmd3.Parameters.AddWithValue("@resetRequestDateTime", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                                            reader.Close();
                                            cmd3.ExecuteNonQuery();

                                            //SEND RESET LINK TO EMAIL
                                            String ToEmailAddress = email;
                                            String ToUserName = Username;
                                            String EmailBody = "Hi, " + ToUserName + ",<br/><br/>Your account has been locked automatically due to multiple incorrect attempts when inputting your password.<br/>Click the link below to activate your account.<br/><a>https://aspj-ezgo.com:44331/Website/Profile/UnlockAccount.aspx?resetCode=" + resetCode + "<a/><br/>Thank you, <br/>Team OCP.";
                                            MailMessage PassRecMail = new MailMessage("\"EzGo \" <ezgo2018@gmail.com>", ToEmailAddress);
                                            PassRecMail.Body = EmailBody;
                                            PassRecMail.IsBodyHtml = true;
                                            PassRecMail.Subject = "Unlock Account";

                                            SmtpClient SMTP = new SmtpClient("smtp.gmail.com", 25);
                                            SMTP.Credentials = new NetworkCredential()
                                            {
                                                UserName = "ezgo2018@gmail.com",
                                                Password = "Cutegirl123"
                                            };

                                            SMTP.EnableSsl = true;
                                            SMTP.Send(PassRecMail);
                                        }*/
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
                                else
                                {
                                    username.Text = string.Empty;
                                    password.Text = string.Empty;
                                    loginWarning.Text = "Invalid user! Please input a valid username.";
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

        private void ToRecoverOTPButton_Click(object sender, EventArgs e)
        {
            LoginOTP loginOTP = new LoginOTP();
            this.Hide();
            loginOTP.ShowDialog();
        }
    }
}
