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
    public partial class LoginForm_CreateNewUser_ : Form
    {
        //Initialised the connction and connectionstring objects/variables used throughout the code
        SqlConnection connection;
        string connectionString;
        string masterMessage = "";
        public LoginForm_CreateNewUser_()
        {
            InitializeComponent();
            //Gets the connection string from app.config by the name given
            connectionString = ConfigurationManager.ConnectionStrings["BankingApplicationProgram.Properties.Settings.DBConnectionString1"].ConnectionString;
        }

        private void LoginForm_CreateNewUser__Load(object sender, EventArgs e)
        {

        }

        private void rb_Existing_CheckedChanged(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        //Username and password validation checks
        private bool ValidationLoginDetails(string username, string password)
        {
            var result1 = true;
            var allowedChars = new Regex("^[a-zA-Z0-9]+$");
            string[] inputsToValidate = new string[2] { username, password };
            string[] inputsToValidateString = new string[2] { "Username", "Password" };
            for (int i = 0; i < 2; i++)
            {
                var message = String.Format("{0} must not contain spaces symbols or be blank and must not be longer than 15 characters, Please try again.", inputsToValidateString[i]);
                if (inputsToValidate[i].Length > 15 || !(allowedChars.IsMatch(inputsToValidate[i])))
                {
                    masterMessage += (message + "\n");
                    result1 = false;
                }

            }
            return result1;
        }

        //Everything else validation checks
        private bool ValidationCustomerDetails(string fName, string lName, string dob, string houseAddress)
        {
            var result2 = true;
            var allowedItems = new Regex("^[a-zA-Z]+$");
            string[] presenceAndRangeCheckedInputs = new string[2] {fName,lName};
            string[] presenceAndRangeCheckedInputsString = new string[2] {"First Name", "Last Name"};
            for (int i = 0; i < 2; i++)
            {
                var message1 = String.Format("{0} must not contain spaces, symbols, numbers or be blank, please try again", presenceAndRangeCheckedInputsString[i]);
                if (!(allowedItems.IsMatch(presenceAndRangeCheckedInputs[i])))
                {
                    masterMessage += (message1 + "\n");
                    result2 = false;
                }
            }

            var houseAddressallowedItems = new Regex("^[a-zA-Z0-9 ]+$");
            var dobAllowedForm = new Regex("^[\\d{2}/\\d{2}/\\d{2}]+$"); //d means digits //{2} means exactly 2 of that type which should give form dd/mm/yy
            //house address check
            if (!(houseAddressallowedItems.IsMatch(houseAddress)))
            {
                masterMessage += "House address must not contain symbols, please try again\n";
                result2 = false;
            }
            //dob form check
            if (!(dobAllowedForm.IsMatch(dob)))
            {
                masterMessage += "Date of birth must be in the form dd/mm/yy, please try again\n";
                result2 = false;
            }
            return result2;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Gets result of validation false = incorrect inputs, true = program may procceed
            var result1 = ValidationLoginDetails(tb_Username.Text, tb_Password.Text);
            var result2 = ValidationCustomerDetails(tb_FName.Text,tb_LName.Text,tb_Dob.Text,tb_HomeAddress.Text);
            if (result1 && result2)
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //Inserts the customer details into tbl_Customer and returns the customerID for use in forming the tbl_Login part of the record
                    using (SqlDataAdapter adapter = new SqlDataAdapter("INSERT INTO tbl_Customer ([First Name],[Last Name],[Gender],[Date Of Birth],[House Address]) VALUES (@FName,@LName,@Gender,@Dob,@HAddress); SELECT SCOPE_IDENTITY()", connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@FName", tb_FName.Text.ToLower());
                        adapter.SelectCommand.Parameters.AddWithValue("@LName", tb_LName.Text.ToLower());
                        adapter.SelectCommand.Parameters.AddWithValue("@Gender", drpbx_Gender.SelectedItem);
                        adapter.SelectCommand.Parameters.AddWithValue("@Dob", tb_Dob.Text);
                        adapter.SelectCommand.Parameters.AddWithValue("@HAddress", tb_HomeAddress.Text.ToLower());
                        DataTable customerID = new DataTable();
                        adapter.Fill(customerID);
                        GlobalVariablesClass.customerID = customerID.Rows[0][0].ToString();
                    }

                    //Inserts the login details into tbl_Login where the code above provides the customerID foreign key link.
                    using (SqlCommand command = new SqlCommand("INSERT INTO tbl_Login ([username],[password],[customerID]) VALUES (@username,@password,@customerID)", connection))
                    {
                        command.Parameters.AddWithValue("@username", tb_Username.Text.ToLower());
                        command.Parameters.AddWithValue("@password", tb_Password.Text.ToLower());
                        command.Parameters.AddWithValue("@customerID", Convert.ToInt32(GlobalVariablesClass.customerID));
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    //Loads the post login screen upon successful database addition
                    PostLoginScreen frm = new PostLoginScreen();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show(masterMessage);
            }
        }
        }
    }

