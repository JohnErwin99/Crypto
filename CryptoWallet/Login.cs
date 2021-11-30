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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm();
            sf.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void singInButton_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
        }
    }
}
