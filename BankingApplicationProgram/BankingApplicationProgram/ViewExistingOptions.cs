using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BankingApplicationProgram
{
    public partial class ViewExistingOptions : Form
    {
        //Initialised the connction and connectionstring objects/variables used throughout the code
        SqlConnection connection;
        string connectionString;

        public ViewExistingOptions()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankingApplicationProgram.Properties.Settings.DBConnectionString1"].ConnectionString;
        }

        private void ViewYourAccounts_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Account WHERE customerID = '" + Convert.ToInt16(GlobalVariablesClass.customerID) + "'", connection))
            {
                DataTable AccountsTable = new DataTable();
                adapter.Fill(AccountsTable);
                lb_YourAccounts.DisplayMember = "Account Number";
                lb_YourAccounts.ValueMember = "Account Number";
                lb_YourAccounts.DataSource = AccountsTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PostLoginScreen frm = new PostLoginScreen();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            GlobalVariablesClass.accountNumber = lb_YourAccounts.SelectedValue.ToString();
            AccountViewingScreen frm = new AccountViewingScreen();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }
    }

}
