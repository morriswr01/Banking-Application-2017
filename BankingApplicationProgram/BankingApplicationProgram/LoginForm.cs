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
using System.Text.RegularExpressions;

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

        private bool ValidationExistingUser(string username, string password) {
            var allowedItems = new Regex("^[a-zA-Z0-9]+$");
            string[] inputsToValidate = new string[2] { username, password };
            for (int i = 0; i < 2; i++)
            {
                if (inputsToValidate[i].Length > 15 || !(allowedItems.IsMatch(inputsToValidate[i])))
                {
                    return false;
                }

            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var result = ValidationExistingUser(tb_Username.Text, tb_Password.Text);
            if (!result)
            {
                MessageBox.Show("Inputs must not contain spaces symbols or be blank and must not be longer than 15 characters, Please try again.");
            }
            else
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Login WHERE username = '" + tb_Username.Text + "' AND password = '" + tb_Password.Text + "'", connection))
                {
                    DataTable loginTable = new DataTable();
                    adapter.Fill(loginTable);
                    if (loginTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Login Incorrect, Please try again.");
                    }
                    else if (loginTable.Rows.Count >= 1)
                    {
                        PostLoginScreen frm = new PostLoginScreen();
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
