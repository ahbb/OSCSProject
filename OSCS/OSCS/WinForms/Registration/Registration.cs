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
        string connstring = "Data Source=localhost;Initial Catalog=oscs;Integrated Security=True; User ID=root;Password=root; SslMode=none";
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
            string contact = txtContactNo.Text;

            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtContactNo.Text == "")
                    MessageBox.Show("Please fill up all fields");
                //lbCheck.Text = "Please fill up all fields";


                else if (txtPassword.Text != txtConfirmPassword.Text)
                    MessageBox.Show("Password do not match");
                //lbPassword.Text = "Password do not match";

                else if (txtContactNo.TextLength != 8)
                    MessageBox.Show("Please enter a valid phone number, e.g. 91234567");
                    //lbContactNo.Text = "Please enter a valid phone number, e.g. 91234567";

                else
                {
                    conn.Open();
                    //query = "";
                    query = "insert into oscs.user(username, password, email, contactNo, salt) values(@username, @password, @email, @contact, @salt)";

                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@salt", "to be added");
                    cmd.ExecuteReader();
                    MessageBox.Show("Registration is successful");

                    conn.Close();
                    Clear();
                }
                
            }

            void Clear()
            {
                txtUsername.Text = txtEmail.Text = txtPassword.Text = txtConfirmPassword.Text = txtContactNo.Text = "";
                //lbCheck.Text = lbContactNo.Text = lbPassword.Text = "";
            }

        }

    }
}
