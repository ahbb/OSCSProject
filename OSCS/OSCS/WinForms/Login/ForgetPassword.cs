using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSCS.WinForms.Registration;
using MySql.Data.MySqlClient;
using log4net;

namespace OSCS.WinForms.Login
{
    public partial class ForgetPassword : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        tDes des = new tDes();
        int userID;
        string username, emailAddress;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ConfirmFPButton_Click(object sender, EventArgs e)
        {
            String CS = System.Configuration.ConfigurationManager.ConnectionStrings["oscs"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(CS);
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                if (string.IsNullOrWhiteSpace(email.Text))
                {
                    FPWarning.Text = "Please input your email in the field below!";
                    FPWarning.ForeColor = System.Drawing.Color.Red;
                }

                else
                {
                    //Check if email exists in database
                    MySqlCommand cmd = new MySqlCommand("select * from oscs.user where email = @email", con);
                    cmd.Parameters.AddWithValue("@email", des.Encrypt(email.Text));
                    con.Open();
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        userID = Convert.ToInt32(reader["userID"].ToString());
                        emailAddress = des.Decrypt(reader.GetString(reader.GetOrdinal("email")));
                        username = reader.GetString(reader.GetOrdinal("username"));
                        reader.Close();

                        //checking whether reset password email has been sent
                        string selectQuery = "SELECT userID FROM oscs.resetpasswordrequests WHERE userID=@userID";
                        MySqlCommand cmd2 = new MySqlCommand(selectQuery, con);
                        cmd2.Parameters.AddWithValue("@userID", userID);
                        reader = cmd2.ExecuteReader();

                        //if email not sent yet
                        if (!reader.Read() && !reader.HasRows)
                        {
                            //Insert request to database
                            String myGUID = Guid.NewGuid().ToString();
                            reader.Close();

                            MySqlCommand cmd1 = new MySqlCommand("INSERT into oscs.resetpasswordrequests (ID,userID) VALUES (@ID, @userID)", conn);
                            conn.Open();
                            cmd1.Parameters.AddWithValue("@ID", myGUID);
                            cmd1.Parameters.AddWithValue("@userID", userID);
                            //cmd1.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                            cmd1.ExecuteNonQuery();

                            //Send reset link to email
                            String ToEmailAddress = emailAddress; //(dt.Rows[0][3].ToString());
                            String ToUserName = username;
                            String EmailBody = "Hi " + ToUserName + ",<br/><br/> In order to set a new password, please use the following reset code: <br/>" + myGUID + "<br/> at the Unlock Account page.<br/>Thank you, <br/>Team Chat Safety.";
                            MailMessage PassRecMail = new MailMessage("\"Chat Security \" <2018oscs@gmail.com>", ToEmailAddress);
                            PassRecMail.Body = EmailBody;
                            PassRecMail.IsBodyHtml = true;
                            PassRecMail.Subject = "Reset Password";

                            SmtpClient SMTP = new SmtpClient("smtp.gmail.com", 25);
                            SMTP.Credentials = new NetworkCredential()
                            {
                                UserName = "2018oscs@gmail.com",
                                Password = "Yuhui123"
                            };

                            SMTP.EnableSsl = true;
                            SMTP.Send(PassRecMail);

                            FPWarning.Text = "Please check your email to reset your password.";
                            FPWarning.ForeColor = Color.Green;

                            log4net.GlobalContext.Properties["userID"] = userID;
                            log.Info("User forgot their password and successfully requested for a reset.");

                            conn.Close();

                        }
                        else
                        {
                            FPWarning.Text = "A request to reset password has already been sent.";
                            FPWarning.ForeColor = Color.Green;
                        }
                        conn.Close();
                    }

                    else
                    {
                        FPWarning.Text = "This email does not exist in our database!";
                        FPWarning.ForeColor = Color.Red;
                    }
                    con.Close();
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration.Registration registration = new Registration.Registration();
            registration.ShowDialog();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
