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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        public string getAmount()
        {
            return amountTextBox.Text;
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            ConfirmInfoForm confirm = new ConfirmInfoForm();
        }
    }
}
