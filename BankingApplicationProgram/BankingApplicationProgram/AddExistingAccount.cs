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
    public partial class AddExistingAccount : Form
    {
        public AddExistingAccount()
        {
            InitializeComponent();
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
    }
}
