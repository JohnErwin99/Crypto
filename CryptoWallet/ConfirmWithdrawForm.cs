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
    public partial class ConfirmWithdrawForm : Form
    {
        public ConfirmWithdrawForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void withdawAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            //get amount from withdraw form
            withdawAmountTextBox.Text = new WithdrawForm().getAmount();
        }

        private void transitNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //get transit from withdraw form
            transitNumberTextBox.Text = new WithdrawForm().getTransit();
        }
    }
}
