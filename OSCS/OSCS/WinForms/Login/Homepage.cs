using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OSCS.WinForms.Login
{
    public partial class Homepage : Form
    {
        int userID;
        string username;

        public Homepage()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginInfo.UserID = 0;
            LoginInfo.UserName = "";
            //Redirect to un-logged-in Homepage
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["oscs"].ConnectionString;
            MySqlConnection MyConnection = new MySqlConnection(cs);
            MyConnection.Open();

            userID = LoginInfo.UserID;
            username = LoginInfo.UserName;

            TitleLabel.Text = "Welcome, " + username;



        }
    }
}
