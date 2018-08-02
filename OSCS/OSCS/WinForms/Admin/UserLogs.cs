using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OSCS.WinForms.Login;

namespace OSCS.WinForms.Admin
{
    public partial class UserLogs : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["oscs"].ConnectionString;
        MySqlDataReader reader;

        public UserLogs()
        {
            InitializeComponent();
        }

        private void UserLogs_Load(object sender, EventArgs e)
        {
            if (Login.LoginInfo.UserID != 1)
            {
                this.Hide();
                Login.Login login = new Login.Login();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                using (MySqlConnection con = new MySqlConnection(CS))
                {
                    con.Open();
                    string selectQuery = "SELECT COUNT(*) FROM logs WHERE userID NOT IN('1')";
                    MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                    int rowsCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (rowsCount > 0)
                    {
                        string selectQuery2 = "SELECT logID,logDateTime,logLevel,logSource,logMessage,logException,userID FROM logs WHERE userID NOT IN ('1')";
                        MySqlCommand cmd2 = new MySqlCommand(selectQuery2, con);
                        reader = cmd2.ExecuteReader();
                        while (reader.HasRows && reader.Read())
                        {
                            string logID = reader["logID"].ToString();
                            string logDateTime = reader["logDateTime"].ToString();
                            string logLevel = reader["logLevel"].ToString();
                            string logSource = reader["logSource"].ToString();
                            string logMessage = reader["logMessage"].ToString();
                            string logException = reader["logException"].ToString();
                            string UserID = reader["userID"].ToString();

                            dv.Rows.Add(logID, logDateTime, logLevel, logSource, logMessage, logException, UserID);
                            foreach (DataGridViewRow row in dv.Rows)
                            {
                                if (Convert.ToString(row.Cells[2].Value) == "WARN")
                                {
                                    row.DefaultCellStyle.BackColor = Color.Red;
                                    row.DefaultCellStyle.ForeColor = Color.White;
                                }
                                else if (Convert.ToString(row.Cells[2].Value) == "INFO")
                                {
                                    row.DefaultCellStyle.BackColor = Color.Green;
                                    row.DefaultCellStyle.ForeColor = Color.Yellow;
                                }
                                else if (Convert.ToString(row.Cells[2].Value) == "ERROR")
                                {
                                    row.DefaultCellStyle.BackColor = Color.LightGray;
                                    row.DefaultCellStyle.ForeColor = Color.Black;
                                }
                            }
                        }
                        reader.Close();
                    }
                    else
                    {
                        dv.Visible = false;
                        noLogs.Visible = true;
                    }
                    con.Close();
                }
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login.LoginInfo.UserID = 0;
            LoginInfo.UserName = "";
            this.Hide();
            Login.Login login = new Login.Login();
            login.ShowDialog();
        }
    }
}
