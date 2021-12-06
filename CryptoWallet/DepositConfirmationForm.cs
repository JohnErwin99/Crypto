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
        private readonly string USER_DB_CONNECTION_STRING = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Users.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        string transitNum;
        string depositAmount;
        public DepositConfirmationForm(string transitNum, string depositAmount)
        {
            InitializeComponent();
            this.transitNum = transitNum;
            this.depositAmount = depositAmount;
            depositAmountTextBox.Text = depositAmount;
            transitNumberTextBox.Text = transitNum;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void transitNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //get the transit number from the deposit form
            transitNumberTextBox.Text = new DepositForm().getTransit();
        }

        private void depositAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            //get the amount from the deposit form
            depositAmountTextBox.Text = new DepositForm().getAmount();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DbConnection deposit = new DbConnection(USER_DB_CONNECTION_STRING, Int32.Parse(depositAmount));
            int remainingCryptoBalance = deposit.readBankingCryptoInformation();
            if (remainingCryptoBalance < 0)
            {
                MessageBox.Show($"Not enough crypto funds.");
            }
            else
            {
                deposit.updateBankingCryptoInformation(remainingCryptoBalance);
            }
        }
    }
}
