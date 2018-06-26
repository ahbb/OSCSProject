using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSCS.WinForms.Admin
{
    public partial class AdminHomepage : Form
    {
        public AdminHomepage()
        {
            InitializeComponent();
        }

        private void AdminHomepage_Load(object sender, EventArgs e)
        {

        }

        private void AdminLogsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogs userlogs = new UserLogs();
            userlogs.ShowDialog();
        }
    }
}
