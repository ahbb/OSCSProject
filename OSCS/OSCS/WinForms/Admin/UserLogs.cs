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

namespace OSCS.WinForms.Admin
{
    public partial class UserLogs : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["oscs"].ConnectionString;
        MySqlDataReader reader;
        MySqlCommand cmd;
        String queryStr;
        DataTable dt = new DataTable();
        //DataGridView dv = new DataGridView();
        BindingSource bs = new BindingSource();

        public UserLogs()
        {
            InitializeComponent();
            dv.Dock = DockStyle.Fill;
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Top;
            panel.AutoSize = true;
            this.Controls.AddRange(new Control[] { dv, panel });
            this.Load += new System.EventHandler(UserLogs_Load);
        }

        private void UserLogs_Load(object sender, EventArgs e)
        {
            dv.DataSource = bs;

            using (MySqlConnection con = new MySqlConnection(CS))
            {
                con.Open();
                string selectQuery = "SELECT COUNT(*) FROM logs WHERE userID NOT IN('1')";
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                int rowsCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (rowsCount > 0)
                {
                    string selectQuery2 = "SELECT logID,logDateTime,logMessage,logLevel,logException,userID FROM logs WHERE userID NOT IN ('1')";
                    MySqlCommand cmd2 = new MySqlCommand(selectQuery2, con);
                    reader = cmd2.ExecuteReader();
                    reader.Close();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd2);

                    dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(dt);
                    bs.DataSource = dt;
                    dv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                }
                else
                {
                    dv.Visible = false;
                    noLogs.Visible = true;
                }
                con.Close();
            }
        }

        /*protected void GridView1_RowCreated(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Log ID";
                e.Row.Cells[1].Text = "Log Date and Time";
                e.Row.Cells[2].Text = "Log Message";
                e.Row.Cells[3].Text = "Log Level";
                e.Row.Cells[4].Text = "Exception";
                e.Row.Cells[5].Text = "User ID";
            }
        }

        protected void GridView1_RowDataBound(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.DataRowType == DataControlRowType.DataRow)
            {
                DataGridCell cell = e.Row.GridCells[3];
                string logLevel = (cell.Text);
                if (logLevel == "ERROR" || logLevel == "FATAL" || logLevel == "WARN")
                {
                    e.Row.BackColor = System.Drawing.Color.Red;
                    e.Row.ForeColor = System.Drawing.Color.White;

                }
            }
        }*/
    }
}
