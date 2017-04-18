using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace BankingApplicationProgram
{
    public partial class AddExistingAccount : Form
    {
        SqlConnection connection;
        string connectionString;
        string answer;

        public AddExistingAccount()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["BankingApplicationProgram.Properties.Settings.DBConnectionString1"].ConnectionString;
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
            GlobalVariablesClass.accountNumber = tb_AccountNumber.Text;
            var allowedItems = new Regex("^[0-9]+$");
            if (!(allowedItems.IsMatch(tb_AccountNumber.Text)))
            {
                MessageBox.Show("Account number must contain only numbers");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Account WHERE [Account Number] = '"+tb_AccountNumber.Text+"'", connection))
                {
                    DataTable AccountTable = new DataTable();
                    adapter.Fill(AccountTable);
                    if (AccountTable.Rows.Count == 0)
                    {
                        MessageBox.Show("There is no account under that account number");
                    }
                    else
                    {
                        lb_SecurityQuestion.Text = AccountTable.Rows[0][3].ToString();
                        answer = AccountTable.Rows[0][4].ToString();
                        tb_AnswerBox.Visible = true;
                        btn_SubmitSQAnswer.Visible = true;
                    }
                }
            }
        }

        private void btn_SubmitSQAnswer_Click(object sender, EventArgs e)
        {
            if (tb_AnswerBox.Text.ToLower() == answer.ToLower())
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("UPDATE tbl_Account SET customerID = '"+Convert.ToInt16(GlobalVariablesClass.customerID)+ "' WHERE [Account Number] = '"+Convert.ToInt16(GlobalVariablesClass.accountNumber)+"' ", connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    AccountViewingScreen frm = new AccountViewingScreen();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect answer please try again");
            }
        }
    }
}
