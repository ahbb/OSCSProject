using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using log4net;

namespace OSCS.WinForms.Login
{
    public partial class LoginOTP : Form
    {
        int userID;
        static string OTPReturn;
        private static double timeElapsed;
        static Stopwatch sw;
        static Timer timer;

        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LoginOTP()
        {
            InitializeComponent();
        }

        private void LoginOTP_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["oscs"].ConnectionString;
            MySqlConnection MyConnection = new MySqlConnection(cs);
            MyConnection.Open();
            MySqlDataReader reader;

            result.Visible = false;
            userID = LoginInfo.UserID;

            using (MySqlCommand HPCommand = new MySqlCommand("SELECT contactNo FROM user WHERE userID = @userID", MyConnection))
            {
                HPCommand.Parameters.AddWithValue("@userID", userID);
                reader = HPCommand.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    string lastHPDigits;
                    lastHPDigits = /*des.Decrypt*/(reader["contactNo"].ToString()); //Decryption of user's phone number
                    HPNum.Text = lastHPDigits.Substring((Math.Max(0, lastHPDigits.Length - 4))); //For the old label in webpage
                }
                reader.Close();
            }
            MyConnection.Close();
            MyConnection.Open();

            timer = new Timer();
            timer.Interval = 30000; // 120000; //time in milliseconds
            timer.Tick += timer_Tick;
            timer.Start();
            RefreshButton.Enabled = false;

            sw = new Stopwatch();
            sw.Start();

            //string response = OTPStr("82540002", "realitymusic1", "65" + hpnumber, "Your One-Time-Password for application OCP is *OTP*");
            //OTPReturn = response.Substring(Math.Max(0, response.Length - 5));
            //OTPReturn = "11111";
            Random random = new Random();
            OTPReturn = random.Next(1, 1000).ToString();
            Console.Out.WriteLine(OTPReturn);
        }

        void timer_Tick(object sender, System.EventArgs e)
        {
            RefreshButton.Enabled = true;
            timer.Stop();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            result.Text = "";
            timer = new Timer();
            timer.Interval = 30000; // 120000; //time in milliseconds
            timer.Tick += timer_Tick;
            timer.Start();
            RefreshButton.Enabled = false;

            sw = new Stopwatch();
            sw.Start();

            //string response = OTPStr("82540002", "realitymusic1", "65" + hpnumber, "Your One-Time-Password for application OCP is *OTP*");
            //OTPReturn = response.Substring(Math.Max(0, response.Length - 5));
            //OTPReturn = "11111";
            Random random = new Random();
            OTPReturn = random.Next(1, 1000).ToString();
            Console.Out.WriteLine(OTPReturn);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["oscs"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);

            if (string.IsNullOrWhiteSpace(InputOTP.Text))
            {
                result.Text = "Please input the 5 digit OTP that has been sent to your mobile phone!";
                result.ForeColor = System.Drawing.Color.Red;
                result.Visible = true;
            }

            else
            {
                timeElapsed = sw.Elapsed.TotalSeconds;
                string userOTPInput = InputOTP.Text;
                if (userOTPInput.Equals(OTPReturn))
                {
                    if (timeElapsed > 120 || timeElapsed <= 0) 
                    {
                        InputOTP.Text = string.Empty;
                        result.Text = "Your One-Time-Password has expired or has been invalidated! \nYou can request for another OTP to be sent to you via the Resend button below.";
                        result.ForeColor = System.Drawing.Color.Red;
                        result.Visible = true;
                    }
                    else
                    {
                        result.Text = "One-Time-Password is correct!";
                        result.ForeColor = System.Drawing.Color.ForestGreen;
                        result.Visible = true;

                        string cs = ConfigurationManager.ConnectionStrings["oscs"].ConnectionString;
                        MySqlConnection MyConnection = new MySqlConnection(cs);
                        MyConnection.Open();

                        log4net.GlobalContext.Properties["userID"] = userID;
                        log.Info("User successfully logged in with OTP verification.");

                        string query = "UPDATE user SET status=@status,counter=@counter WHERE userID=@userID";
                        MySqlCommand cmdd = new MySqlCommand(query, MyConnection);
                        cmdd.Parameters.AddWithValue("@status", "green");
                        cmdd.Parameters.AddWithValue("@userID", userID);
                        cmdd.Parameters.AddWithValue("@counter", 0);
                        cmdd.ExecuteNonQuery();
                        MyConnection.Close();

                        Homepage homepage = new Homepage();
                        this.Hide();
                        homepage.ShowDialog();
                    }
                }
                else
                {
                    InputOTP.Text = string.Empty;
                    result.Text = "Your One-Time-Password is incorrect!";
                    result.ForeColor = System.Drawing.Color.Red;
                    result.Visible = true;

                    using (MySqlConnection con = new MySqlConnection(connString))
                    {
                        con.Open();
                        string selectQuery = "SELECT counter FROM user WHERE userID=@userID";
                        MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                        cmd.Parameters.AddWithValue("@userID", userID);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows && reader.Read())
                        {
                            log4net.GlobalContext.Properties["userID"] = userID;
                            log.Error("Authentication failed - User failed an OTP Verification Login Attempt");
                            int counter = reader.GetInt32(reader.GetOrdinal("counter"));
                            reader.Close();
                            counter += 1;
                            if (counter >= 3)
                            {
                                string query = "UPDATE user SET status=@status,counter=@counter WHERE userID=@userID";
                                conn.Close();
                                conn.Open();
                                MySqlCommand cmdd = new MySqlCommand(query, conn);
                                cmdd.Parameters.AddWithValue("@status", "red");
                                cmdd.Parameters.AddWithValue("@userID", userID);
                                cmdd.Parameters.AddWithValue("@counter", counter);
                                cmdd.ExecuteNonQuery();

                                result.Text = "Your One-Time-Password is incorrect! The account that you are trying to access has been locked. An email with relevant information has been sent to account owner.";
                                result.ForeColor = System.Drawing.Color.Red;
                                result.Visible = true;

                                //checking whether email has been sent
                                /*string selectQuery2 = "SELECT userID FROM resetpasswordrequests WHERE userID=@userID";
                                MySqlCommand cmd2 = new MySqlCommand(selectQuery2, con);
                                cmd2.Parameters.AddWithValue("@userID", userID);
                                reader = cmd2.ExecuteReader();

                                //email not sent yet
                                if (!reader.Read() && !reader.HasRows) 
                                {
                                    String resetCode = Guid.NewGuid().ToString();
                                    string insertQuery = "INSERT INTO resetpasswordrequests (ID,userID,resetRequestDateTime) VALUES (@ID,@userID,@resetRequestDateTime)";
                                    MySqlCommand cmd3 = new MySqlCommand(insertQuery, con);
                                    cmd3.Parameters.AddWithValue("@ID", resetCode);
                                    cmd3.Parameters.AddWithValue("@userID", userID);
                                    cmd3.Parameters.AddWithValue("@resetRequestDateTime", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                                    reader.Close();
                                    cmd3.ExecuteNonQuery();

                                    //SEND RESET LINK TO EMAIL
                                    String ToEmailAddress = email;
                                    String ToUserName = Username;
                                    String EmailBody = "Hi, " + ToUserName + ",<br/><br/>Your account has been locked automatically due to multiple incorrect attempts when inputting your password.<br/>Click the link below to activate your account.<br/><a>https://aspj-ezgo.com:44331/Website/Profile/UnlockAccount.aspx?resetCode=" + resetCode + "<a/><br/>Thank you, <br/>Team OCP.";
                                    MailMessage PassRecMail = new MailMessage("\"OCP \" <2018oscs@gmail.com>", ToEmailAddress);
                                    PassRecMail.Body = EmailBody;
                                    PassRecMail.IsBodyHtml = true;
                                    PassRecMail.Subject = "Unlock Account";

                                    SmtpClient SMTP = new SmtpClient("smtp.gmail.com", 25);
                                    SMTP.Credentials = new NetworkCredential()
                                    {
                                        UserName = "2018oscs@gmail.com",
                                        Password = "Yuhui123"
                                    };

                                    SMTP.EnableSsl = true;
                                    SMTP.Send(PassRecMail);
                                }*/
                            } //if counter >= 3 end

                            else
                            {
                                string query = "UPDATE user SET counter=@counter where userID=@userID";
                                conn.Close();
                                conn.Open();
                                MySqlCommand cmdd = new MySqlCommand(query, conn);
                                cmdd.Parameters.AddWithValue("@counter", counter);
                                cmdd.Parameters.AddWithValue("@userID", userID);
                                cmdd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        public static string OTPStr(string ID, string Password, string mobile, string msg)
        {
            string response = "";
            try
            {
                //Construct Send Params.
                string gateWay = "https://www.commzgate.net/gateway/SendMsg?";
                //Setup Params
                string paramData = "";
                paramData += "ID=" + ID + "&";
                paramData += "Password=" + Password + "&";
                paramData += "Mobile=" + mobile + "&";
                paramData += "Type=" + "A" + "&";
                paramData += "Message=" + System.Uri.EscapeDataString(msg) + "&";
                paramData += "OTP=true";

                //Ensure Ascii format
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] ASCIIparamData = encoding.GetBytes(paramData);

                //Setting Request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(gateWay);
                request.Method = "POST";

                request.Accept = "text/plain";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = ASCIIparamData.Length;

                //Sending Request.
                Stream streamReq = request.GetRequestStream();
                streamReq.Write(ASCIIparamData, 0, ASCIIparamData.Length);

                //Get Response
                HttpWebResponse HttpWResp = (HttpWebResponse)request.GetResponse();
                Stream streamResponse = HttpWResp.GetResponseStream();

                //Read the Response.. and open a dialog
                StreamReader reader = new StreamReader(streamResponse);
                response = reader.ReadToEnd();

                return response;
            }
            catch (Exception e)
            {
                return "" + e;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoginInfo.UserID = -1;
            LoginInfo.UserName = "";
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration.Registration registration = new Registration.Registration();
            registration.ShowDialog();
        }
    }
}
