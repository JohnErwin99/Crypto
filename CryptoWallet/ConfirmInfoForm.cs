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
        public ConfirmInfoForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sendingAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void recieverTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
