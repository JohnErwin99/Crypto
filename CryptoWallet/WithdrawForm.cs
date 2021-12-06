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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            ConfirmWithdrawForm confWithdraw = new ConfirmWithdrawForm(getTransit(), getAmount());
            confWithdraw.Show();
        }

        private void transitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public string getTransit()
        {
            return transitTextBox.Text;
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        public string getAmount()
        {
            return amountTextBox.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
