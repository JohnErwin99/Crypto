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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string first = firstNameTextbox.Text;
            string last = lastNameTextbox.Text;
            string email = emailTextbox.Text;
            int age = ageComboBox.SelectedIndex;
            string password = passwordTextBox.Text;

            User user = new User(first, last, email, age, password);
        }
    }
}
