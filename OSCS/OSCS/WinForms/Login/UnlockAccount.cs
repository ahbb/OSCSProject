using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OSCS.WinForms.Registration;

namespace OSCS.WinForms.Login
{
    public partial class UnlockAccount : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        DataTable dt = new DataTable();
        string username, uid;
        static string  email;
        int userID;
        tDes des = new tDes();

        public UnlockAccount()
        {
            InitializeComponent();
        }

        private void UnlockAccount_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            passwordPanel.Visible = false;
            String cs = System.Configuration.ConfigurationManager.ConnectionStrings["oscs"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(cs);

            if (!string.IsNullOrWhiteSpace(resetCode.Text))
            {
                using (MySqlCommand mainCommand = new MySqlCommand("SELECT * FROM oscs.resetpasswordrequests WHERE ID = @ResetCode", conn))
                {
                    conn.Open();
                    mainCommand.Parameters.AddWithValue("@ResetCode", resetCode.Text);
                    reader = mainCommand.ExecuteReader();

                    if (reader.HasRows && reader.Read())
                    {
                        uid = reader["ID"].ToString();
                        userID = Convert.ToInt32(reader["userID"].ToString()); // Convert.ToInt32(dt.Rows[0][1]);
                        reader.Close();

                        using (MySqlCommand selectCommand = new MySqlCommand("SELECT email, username FROM oscs.user WHERE userID = @userID", conn))
                        {
                            selectCommand.Parameters.AddWithValue("@userID", userID);
                            reader = selectCommand.ExecuteReader();

                            while (reader.HasRows && reader.Read())
                            {
                                email = des.Decrypt(reader.GetString(reader.GetOrdinal("email")));
                                username = reader.GetString(reader.GetOrdinal("username"));
                            }
                            reader.Close();

                            passwordPanel.Visible = true;
                            resetLabel.Text = "Reset code is correct";
                            resetLabel.ForeColor = Color.Green;
                            resetCode.Text = "";
                        }
                    }
                    else
                    {
                        resetLabel.Text = "Reset code is incorrect";
                        resetLabel.ForeColor = Color.Red;
                    }
                    conn.Close();
                }
            }
            else
            {
                resetLabel.Text = "Please input the reset code";
                resetLabel.ForeColor = Color.Red;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            resetLabel.Text = "";
            if (password.Text == "" | newPassword.Text == "")
            {
                check.Text = "Both password input fields cannot be empty!";
            }
            else if (password.Text != newPassword.Text | !ValidatePassword(password.Text))
            {
                confirmPassword.ForeColor = Color.Red;
            }
            else
            {
                check.Text = "";
                conn.Open();
                string salt = Crypto.GenerateSalt();
                string hashedPassword = Crypto.HashPassword(password.Text + salt);
                using (MySqlCommand updateCommand = new MySqlCommand("UPDATE oscs.user SET password = @password, salt = @salt, counter = @counter, status = @status WHERE userID = @userID", conn))
                {
                    updateCommand.Parameters.AddWithValue("@password", hashedPassword);
                    updateCommand.Parameters.AddWithValue("@salt", salt);
                    updateCommand.Parameters.AddWithValue("@counter", 0);
                    updateCommand.Parameters.AddWithValue("@status", "green");
                    updateCommand.Parameters.AddWithValue("@userID", userID);
                    reader = updateCommand.ExecuteReader();
                    reader.Close();

                    using (MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM oscs.resetpasswordrequests WHERE ID = @ResetCode", conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@ResetCode", uid);
                        reader = deleteCommand.ExecuteReader();
                        reader.Close();
                    }
                }
                //send email to notify them 
                sendMsg(username, email);

                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //input validation check for Confirm Password Input Field
        private void newPassword_TextChanged(object sender, EventArgs e)
        {
            check.Text = "";
            if (newPassword.Text.Length < 1)
            {
                confirmNewPassword.Text = "Confirm New Password not inputted";
                confirmNewPassword.ForeColor = Color.Red;
            }
            else if (newPassword.Text != password.Text)
            {
                confirmNewPassword.Text = "Passwords do not match";
                confirmNewPassword.ForeColor = Color.Red;
            }
            else if (newPassword.Text == password.Text)
            {
                confirmNewPassword.Text = "";
            }
        }
        //input validation check for Password Input Field
        private void password_TextChanged(object sender, EventArgs e)
        {
            check.Text = "";
            if (password.Text.Length < 1)
            {
                confirmPassword.Text = "New Password not inputted";
                confirmPassword.ForeColor = Color.Red;
            }
            else if (!ValidatePassword(password.Text))
            {
                confirmPassword.Text = "New Password must be at least 8 characters, with at least 1 number, 1 lowercase and 1 uppercase.";
                confirmPassword.ForeColor = Color.Red;
            }
            else
            {
                confirmPassword.Text = "";
            }
        }

        public bool ValidatePassword(string password)
        {
            string patternPassword = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$";
            if (!string.IsNullOrEmpty(password))
            {
                if (!Regex.IsMatch(password, patternPassword))
                {
                    return false;
                }
            }
            return true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration.Registration registration = new Registration.Registration();
            registration.ShowDialog();
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
            msg.Subject = "Account Unlocked and Password Changed";
            msg.Body = "Hello " + username + ", your account has been unlocked and password has been reset.</br>";

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
