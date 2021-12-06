using CryptoWallet.Properties;
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
    public partial class BuyMoreForm : Form
    {
        private readonly string CRYPTO_DB_CONNECTION_STRING = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Crypto.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private readonly string USER_DB_CONNECTION_STRING = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Users.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        //Create dbcontext for crypto
        int NextClick = 0;
        private CryptoWallet.CryptoEntities cryptoCbContext =
            new CryptoWallet.CryptoEntities();
 

        public BuyMoreForm()
        {
            InitializeComponent();
            pictureBox1.Image = Resources.d2;
            cryptoNameLbl.Text = Resources.DiabloName;
        }
        //manually added photo to resources,in CryptoWallet/properties/Resources
        private void NextBtn_Click(object sender, EventArgs e)
        {
            NextClick++;

            switch (NextClick)
            {
                case 0:
                    pictureBox1.Image = Resources.d2;
                    cryptoNameLbl.Text = Resources.DiabloName;
                break;
                case 1:
                    pictureBox1.Image = Resources.ogre;
                    cryptoNameLbl.Text = Resources.OgreName;
                    break;
                case 2:
                    pictureBox1.Image = Resources.Guy;
                    cryptoNameLbl.Text = Resources.GuyName;
                break;
                case 3:
                    pictureBox1.Image = Resources.trippy;
                    cryptoNameLbl.Text = Resources.TrippyName;
                    NextClick = -1;
                    break;
            } 
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            NextClick--;

            switch (NextClick)
            {
                case 0:
                    pictureBox1.Image = Resources.d2;
                    cryptoNameLbl.Text = Resources.DiabloName;
                    break;
                case -1:
                    pictureBox1.Image = Resources.trippy;
                    cryptoNameLbl.Text = Resources.TrippyName;

                    break;
                case -2:
                    pictureBox1.Image = Resources.Guy;
                    cryptoNameLbl.Text = Resources.GuyName;

                    break;
                case -3:
                    pictureBox1.Image = Resources.ogre;
                    cryptoNameLbl.Text = Resources.OgreName;

                    NextClick = 1;
                    break;
            }
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {
            CryptoInfoViewer cryptoviewer =  new CryptoInfoViewer(cryptoNameLbl.Text);
            cryptoviewer.Show();
        }

        //3 step db interaction Get price of current item, insert name, price and qty of stock bought and update the debit balance of user.
        private void buyBtn_Click(object sender, EventArgs e)
        {
            //take quantity buy
            int quantity = Int32.Parse(qtyTextBox.Text);

            //get the price of current item
            DbConnection getPrice = new DbConnection(CRYPTO_DB_CONNECTION_STRING, cryptoNameLbl.Text, quantity);
            string itemprice = getPrice.readCryptoInformation();

            //calculate total price of current stock bought
            int TotalPrice = quantity * Int32.Parse(itemprice);

            //update balance in user BankingInformation Table with totalprice
            DbConnection updateDebitBalance = new DbConnection(USER_DB_CONNECTION_STRING, TotalPrice);
            int remainingBalance = updateDebitBalance.readBankingInformation();
            
            if(remainingBalance < 0)
            {
                MessageBox.Show($"Not enough funds.");
            }
            else
            {
                updateDebitBalance.updateBankingInformation(remainingBalance);
                //open database and insert name, price and quantity crypto bought into cryptoinformation table in user database.
                DbConnection insertStockBought = new DbConnection(USER_DB_CONNECTION_STRING, cryptoNameLbl.Text, Int32.Parse(itemprice), quantity);
                insertStockBought.insertCryptoInformation();
            }
                
            

        }
    }
}
