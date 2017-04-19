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
    public partial class AccountViewingScreen : Form
    {
        public AccountViewingScreen()
        {
            InitializeComponent();
            var accountNumber = GlobalVariablesClass.accountNumber;
        }

        private void AccountViewingScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.tbl_Transaction' table. You can move, or remove it, as needed.
            this.tbl_TransactionTableAdapter.Fill(this.dBDataSet.tbl_Transaction);

        }
    }
}
