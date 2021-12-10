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
    public partial class ConfirmInfoForm : Form
    {
        private readonly string USER_DB_CONNECTION_STRING = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Users.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        int sendCounter = 0;
        private string transferAmount;
        private string email;
        public ConfirmInfoForm()
        {
            InitializeComponent();
        }

        public ConfirmInfoForm(string transferAmount, string email)
        {
            InitializeComponent();
            this.transferAmount = transferAmount;
            this.email = email;
            receiverTxtBox.Text = email;
            sendingAmountTextBox.Text = transferAmount;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            HomeForm goHome = new HomeForm();
            goHome.Show();
            this.Hide();
        }

        private void sendingAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            // getting the amount from the Transfer Form
            sendingAmountTextBox.Text = new TransferForm().getAmount();
        }

        private void recieverTextBox_TextChanged(object sender, EventArgs e)
        {
            // getting the email address from the Transfer Form
            receiverTxtBox.Text = new TransferForm().getEmail();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            ++sendCounter;
            if(sendCounter % 2 == 0)
            {
                FillesAndStreams output = new FillesAndStreams();
                output.chooseDirectory();
                output.saveData(1, email, Int32.Parse(transferAmount));
                output.closeWriter();
            }
            else
            {
                DbConnection transfer = new DbConnection(USER_DB_CONNECTION_STRING, Int32.Parse(transferAmount));
                int remainingCryptoBalance = transfer.readBankingInformation();
                if (remainingCryptoBalance < 0)
                {
                    MessageBox.Show($"Not enough crypto funds.");
                }
                else
                {
                    transfer.updateBankingCryptoInformation(remainingCryptoBalance);
                }
                //eveytime you send a transfer it writes it to a file at the same time.
                MessageBox.Show("You should save your file for record keeping. Click Save file and choose where to save and click send again.");
            }

            if(sendCounter >= 3)
            {
                HomeForm goHome = new HomeForm();
                goHome.Show();
                this.Hide();
            }
        }
    }
}
