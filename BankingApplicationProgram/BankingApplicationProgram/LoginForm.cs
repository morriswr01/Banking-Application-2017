using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BankingApplicationProgram
{
    public partial class LoginForm : Form
    {
        SqlConnection connection;
        string connectionString;

        public LoginForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["BankingApplicationProgram.Properties.Settings.DBConnectionString1"].ConnectionString;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void NewUser_Selected(object sender, EventArgs e)
        {

            LoginForm_CreateNewUser_ frm = new LoginForm_CreateNewUser_();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Login", connection))
            {
                DataTable loginTable = new DataTable();
                adapter.Fill(loginTable);

                testListBox.DisplayMember = "username";
                testListBox.ValueMember = "LoginID";
                testListBox.DataSource = loginTable;

            }
            
            //PostLoginScreen frm = new PostLoginScreen();
            //this.Hide();
            //frm.ShowDialog();
            //this.Close();
        }
    }
}
