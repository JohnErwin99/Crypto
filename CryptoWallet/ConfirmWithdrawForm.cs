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
        private readonly string USER_DB_CONNECTION_STRING = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Users.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        string transitNum;
        string withdrawAmount;
        public ConfirmWithdrawForm()
        {   
            InitializeComponent();
        }
        public ConfirmWithdrawForm(string transitNum, string withdrawAmount)
        {
            InitializeComponent();
            this.transitNum = transitNum;
            this.withdrawAmount = withdrawAmount;
            transitNumberTextBox.Text = transitNum;
            withdawAmountTextBox.Text = withdrawAmount;
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

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            DbConnection withdraw = new DbConnection(USER_DB_CONNECTION_STRING, Int32.Parse(withdrawAmount));
            int remainingBalance = withdraw.readBankingInformation();

            withdraw.updateBankingInformation(remainingBalance);
        }
    }
}
