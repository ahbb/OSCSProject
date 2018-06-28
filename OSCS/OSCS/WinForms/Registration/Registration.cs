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

namespace OSCS.WinForms.Registration
{
    public partial class Registration : Form
    {
        string connstring = "Data Source=localhost;Initial Catalog=oscs;Integrated Security=True; User ID=root;Password=root";
        MySqlCommand cmd;
        string query;
        
        public Registration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string phone = txtPhoneNo.Text;

            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtPhoneNo.Text == "")
                    MessageBox.Show("Please fill up all fields");

                else if (txtPassword.Text != txtConfirmPassword.Text)
                    MessageBox.Show("Password do not match");

                else
                {
                    conn.Open();
                    //query = "";
                    query = "insert into oscs.user(username, email, password, phoneNo) values(@username, @email, @password, @phoneNo)";

                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@phoneNo", txtPhoneNo.Text);
                    cmd.ExecuteReader();
                    MessageBox.Show("Registration is successful");

                    conn.Close();
                    Clear();
                }
            }

            void Clear()
            {
                txtUsername.Text = txtEmail.Text = txtPassword.Text = txtConfirmPassword.Text = txtPhoneNo.Text = "";
            }

        }
    }
}
