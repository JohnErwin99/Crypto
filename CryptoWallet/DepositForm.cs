using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWallet
{
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            DepositConfirmationForm confirmDeposit = new DepositConfirmationForm(getTransit(),getAmount());
            confirmDeposit.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void transitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public string getTransit()
        {
            return transitTextBox.Text;
        }
        private void depositAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public string getAmount()
        {
            return depositAmountTextBox.Text;
        }
    }
}
