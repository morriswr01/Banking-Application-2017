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
        SqlConnection connection;
        string connectionString;

        public LoginForm_CreateNewUser_()
        {
            InitializeComponent();

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

        private void button1_Click(object sender, EventArgs e)
        {
            PostLoginScreen frm = new PostLoginScreen();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        //Username and password validation checks
        private bool ValidationLoginDetails(string username, string password)
        {
            var result1 = true;
            var allowedSymbols = new Regex("^[a-zA-Z0-9]+$");
            string[] inputsToValidate = new string[2] { username, password };
            for (int i = 0; i < 2; i++)
            {
                if (inputsToValidate[i].Length > 15 || !(allowedSymbols.IsMatch(inputsToValidate[i])))
                {
                    MessageBox.Show("#1");
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
            for (int i = 0; i < 2; i++)
            {
                if (!(allowedItems.IsMatch(presenceAndRangeCheckedInputs[i])))
                {
                    MessageBox.Show("#2");
                    result2 = false;
                }
            }

            var houseAddressallowedItems = new Regex("^[a-zA-Z0-9 ]+$");
            var dobAllowedForm = new Regex("^[\\d{2}/\\d{2}/\\d{2}]+$"); //d means digits //{2} means exactly 2 of that type which should give form dd/mm/yy
            //house address check
            if (!(houseAddressallowedItems.IsMatch(houseAddress)))
            {
                MessageBox.Show("#3");
                result2 = false;
            }
            //dob form check
            if (!(dobAllowedForm.IsMatch(dob)))
            {
                MessageBox.Show("#4");
                result2 = false;
            }
            return result2;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ValidationLoginDetails(tb_Username.Text, tb_Password.Text);
            ValidationCustomerDetails(tb_FName.Text,tb_LName.Text,tb_Dob.Text,tb_HomeAddress.Text);









        //    using (connection = new SqlConnection(connectionString))
        //    {
        //        //Inserts the customer details into tbl_Customer
        //        using (SqlCommand command = new SqlCommand("INSERT INTO tbl_Customer ([First Name],[Last Name],[Gender],[Date Of Birth],[House Address]) VALUES (@FName,@LName,@Gender,@Dob,@HAddress)", connection))
        //        {
        //            command.Parameters.AddWithValue("@FName", tb_FName.Text);
        //            command.Parameters.AddWithValue("@LName", tb_LName.Text);
        //            command.Parameters.AddWithValue("@Gender", drpbx_Gender.SelectedItem);
        //            command.Parameters.AddWithValue("@Dob", tb_Dob.Text);
        //            command.Parameters.AddWithValue("@HAddress", tb_HomeAddress.Text);
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            connection.Close();
        //        }
        //        //Gets the customerID of the record inserted above using the same criteria
        //        using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT customerID FROM tbl_customer WHERE [First Name]='" + tb_FName.Text + "' AND [Last Name]= '" + tb_LName.Text + "' AND [Date Of Birth]= '"+tb_Dob.Text+"' ", connection))
        //        {
        //            DataTable customerIDJustCreated = new DataTable();
        //            adapter.Fill(customerIDJustCreated);
        //            var customerID = customerIDJustCreated.Rows[0][0];
        //        //Inserts the login details into tbl_Login where the code above provides the customerID foreign key link.
        //            using (SqlCommand command = new SqlCommand("INSERT INTO tbl_Login ([username],[password],[customerID]) VALUES (@username,@password,@customerID)", connection))
        //            {
        //                command.Parameters.AddWithValue("@username", tb_Username.Text);
        //                command.Parameters.AddWithValue("@password", tb_Password.Text);
        //                command.Parameters.AddWithValue("@customerID", Convert.ToInt32(customerID));
        //                connection.Open();
        //                command.ExecuteNonQuery();
        //                connection.Close();
        //            }
        //        }
        //    }
        //    //Loads the post login screen upon successful database addition
        //    PostLoginScreen frm = new PostLoginScreen();
        //    this.Hide();
        //    frm.ShowDialog();
        //    this.Close();
        }
        }
    }

