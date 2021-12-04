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
    public partial class DepositConfirmationForm : Form
    {
        public DepositConfirmationForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void transitNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //get the transit number from the deposit form
            transitNumberTextBox.Text = new DepositFormcs().getTransit();
        }

        private void depositAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            //get the amount from the deposit form
            depositAmountTextBox.Text = new DepositFormcs().getAmount();
        }
    }
}
