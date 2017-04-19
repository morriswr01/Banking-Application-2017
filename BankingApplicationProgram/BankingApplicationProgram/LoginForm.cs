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
        //Initialised the connction and connectionstring objects/variables used throughout the code
        SqlConnection connection;
        string masterMessage = "";
        public LoginForm()
        {
            InitializeComponent();
            //Gets the connection string from app.config by the name given
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void NewUser_Selected(object sender, EventArgs e)
        {
            //Loads new user options
            LoginForm_CreateNewUser_ frm = new LoginForm_CreateNewUser_();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        //Username and password validation checks
        private bool ValidationExistingUser(string username, string password) {
            var allowedItems = new Regex("^[a-zA-Z0-9]+$");
            var result = true;
            string[] inputsToValidate = new string[2] { username, password };
            string[] inputsToValidateString = new string[2] { "Username", "Password" };
            //For each user input applies the allowedItems regex and checks that only allowed ranges are matched
            for (int i = 0; i < 2; i++)
            {
                var message = String.Format("{0} must not contain spaces, symbols or be blank and must not be longer than 15 characters, Please try again.", inputsToValidateString[i]);
                if (inputsToValidate[i].Length > 15 || !(allowedItems.IsMatch(inputsToValidate[i])))
                {
                    masterMessage += (message + "\n");
                    result = false;
                }

            }
            return result;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Gets result of validation false = incorrect inputs, true = program may procceed
            var result = ValidationExistingUser(tb_Username.Text, tb_Password.Text);
            if (result)
            {
                //Checks if there is a matching username and password in tbl_Login
                using (connection = new SqlConnection(GlobalVariablesClass.connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Login WHERE username = '" + tb_Username.Text.ToLower() + "' AND password = '" + tb_Password.Text.ToLower() + "'", connection))
                {
                    DataTable loginTable = new DataTable();
                    adapter.Fill(loginTable);
                    //No match found, error message shown
                    if (loginTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Login Incorrect, Please try again.");
                    }
                    //Match found and program proceeds to post login screen using this login
                    else if (loginTable.Rows.Count >= 1)
                    {
                        GlobalVariablesClass.customerID = loginTable.Rows[0][3].ToString();
                        PostLoginScreen frm = new PostLoginScreen();
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();

                    }
                }
            }
            else
            {
                MessageBox.Show(masterMessage);
            }
        }
    }
}
