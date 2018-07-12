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
using MySql.Data.MySqlClient;

namespace OSCS.WinForms.Login
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmFPButton_Click(object sender, EventArgs e)
        {
            String CS = System.Configuration.ConfigurationManager.ConnectionStrings["oscs"].ToString();
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                if (string.IsNullOrWhiteSpace(email.Text))
                {
                    FPWarning.Text = "Please input your email!";
                    FPWarning.ForeColor = System.Drawing.Color.Red;
                }

                else
                {
                    //Check if email exists in database
                    MySqlCommand cmd = new MySqlCommand("select * from oscs.user where email=@email", con);
                    cmd.Parameters.AddWithValue("@email", /*des.Encrypt2*/(email.Text));
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count != 0)
                    {
                        //Inser request to database
                        String myGUID = Guid.NewGuid().ToString();
                        int userID = Convert.ToInt32(dt.Rows[0][0]);
                        MySqlCommand cmd1 = new MySqlCommand("insert into oscs.resetpasswordrequests values(@guid, @userid, @datetime)", con);
                        cmd1.Parameters.AddWithValue("@guid", myGUID);
                        cmd1.Parameters.AddWithValue("@userid", userID);
                        cmd1.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        cmd1.ExecuteNonQuery();

                        //Send reset link to email
                        /*String ToEmailAddress = /*des.Decrypt2(dt.Rows[0][5].ToString());
                        String Firstname = dt.Rows[0][1].ToString();
                        String EmailBody = "Hi, " + Firstname + ",<br/><br/> We have received your forget password request.<br/>Click the link below to continue.<br/><a>https://aspj-ezgo.com:44331/WebSite/Profile/RecoverPassword.aspx?userID=" + myGUID + "<a/><br/>Thank you, <br/>Team EzGo.";
                        MailMessage PassRecMail = new MailMessage("\"EzGo \" <ezgo2018@gmail.com>", ToEmailAddress);
                        PassRecMail.Body = EmailBody;
                        PassRecMail.IsBodyHtml = true;
                        PassRecMail.Subject = "Reset Password";

                        SmtpClient SMTP = new SmtpClient("smtp.gmail.com", 25);
                        SMTP.Credentials = new NetworkCredential()
                        {
                            UserName = "ezgo2018@gmail.com",
                            Password = "Cutegirl123"
                        };

                        SMTP.EnableSsl = true;
                        SMTP.Send(PassRecMail);*/

                        FPWarning.Text = "Please check your email to reset your password.";
                        FPWarning.ForeColor = Color.Green;
                    }

                    else
                    {
                        FPWarning.Text = "This email does not exist in our database!";
                        FPWarning.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
