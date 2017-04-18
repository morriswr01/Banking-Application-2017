using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BankingApplicationProgram
{
    public partial class CreateNewAccount : Form
    {
        //Initialised the connction and connectionstring objects/variables used throughout the code
        SqlConnection connection;
        string connectionString;
        public CreateNewAccount()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankingApplicationProgram.Properties.Settings.DBConnectionString1"].ConnectionString;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_SecurityQAnswer.Text != "" && cb_AccountType.Text != "" && cb_SecurityQuestion.Text != "")
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO tbl_Account([Account Type],[Account Balance],[Security Question],[Security Question Answer],[customerID]) VALUES (@accountType,'0',@SecQues,@SecQuesAns,@customerID); SELECT SCOPE_IDENTITY()", connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@accountType", cb_AccountType.SelectedItem);
                    adapter.SelectCommand.Parameters.AddWithValue("@SecQues", cb_SecurityQuestion.SelectedItem);
                    adapter.SelectCommand.Parameters.AddWithValue("@SecQuesAns", tb_SecurityQAnswer.Text.ToLower());
                    adapter.SelectCommand.Parameters.AddWithValue("@customerID", Convert.ToInt16(GlobalVariablesClass.customerID));
                    DataTable accountNumber = new DataTable();
                    adapter.Fill(accountNumber);
                    GlobalVariablesClass.accountNumber = accountNumber.Rows[0][0].ToString();
                }
                AccountViewingScreen frm = new AccountViewingScreen();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("You must not leave inputs blank");
            }
        }
    }
}
