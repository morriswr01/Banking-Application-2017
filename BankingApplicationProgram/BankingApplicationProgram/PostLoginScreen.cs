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
    public partial class PostLoginScreen : Form
    {
        public PostLoginScreen()
        {
            InitializeComponent();
        }

        public void PostLoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void tb_welcomeBanner_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void ViewExistingAccountBtn_Click(object sender, EventArgs e)
        {
            ViewExistingOptions frm = new ViewExistingOptions();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_AddExistingAccount_Click(object sender, EventArgs e)
        {
            AddExistingAccount frm = new AddExistingAccount();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_CreateNewAccount_Click(object sender, EventArgs e)
        {
            CreateNewAccount frm = new CreateNewAccount();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
