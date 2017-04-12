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

        private void PostLoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewExistingOptions frm = new ViewExistingOptions();
            this.Hide();
            frm.ShowDialog();
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            AddExistingAccount frm = new AddExistingAccount();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
