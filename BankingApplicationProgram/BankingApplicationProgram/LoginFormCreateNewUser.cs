using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplicationProgram
{
    public partial class LoginForm_CreateNewUser_ : Form
    {
        public LoginForm_CreateNewUser_()
        {
            InitializeComponent();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PostLoginScreen frm = new PostLoginScreen();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
