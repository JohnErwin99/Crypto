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
    }
}
