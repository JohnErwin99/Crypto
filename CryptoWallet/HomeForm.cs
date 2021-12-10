using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWallet
{
    public partial class HomeForm : Form
    {


        //Create dbcontext for users
        private CryptoWallet.UsersEntities userCbContext =
            new CryptoWallet.UsersEntities();

        private string email;

        public HomeForm()
        {
            InitializeComponent();
        }
        //added a constuctor to pass data for username
        public HomeForm(string email)
        {
            InitializeComponent();
            this.email = email;
            userNamelabel.Text = email;
            loadUser();
        }

        //method to laod database data
        private void loadData()
        {

            userCbContext.BankingInformations
                .Load();

            bankingInformationBindingSource.DataSource = userCbContext.BankingInformations.Local;
        }

        //method to laod database data
        private void loadUser()
        {

            try
            {
                //load the user currently connected. check the primarykey 
                 userCbContext.BankingInformations
                .Where(id => id.PersonalInformation.Email == userNamelabel.Text)
                .Load();

                 bankingInformationBindingSource.DataSource = userCbContext.BankingInformations.Local;
            }catch (Exception ex)
            {
                MessageBox.Show("Invalid Credentials");
            }
           
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyMoreForm buy = new BuyMoreForm();
            buy.Show();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawForm withdawForm = new WithdrawForm();
            withdawForm.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositForm deposit = new DepositForm();
            deposit.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transfer = new TransferForm();
            transfer.Show();
        }

        private void downloadTransferHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewTxtFile readFile = new viewTxtFile();
            this.Hide();
            readFile.Show();
        }

        private void cryptoBalanceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
