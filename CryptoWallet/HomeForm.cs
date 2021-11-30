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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
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
            SellForm sell = new SellForm();
            sell.Show();
        }
    }
}
