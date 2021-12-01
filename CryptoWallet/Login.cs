using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWallet
{
    public partial class Login : Form
    {
        private readonly string USER_DB_CONNECTION_STRING = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Users.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        //Create dbcontext for users
        private CryptoWallet.UsersEntities userCbContext =
            new CryptoWallet.UsersEntities();

        private string email;
        private string password;


        public Login()
        {
            InitializeComponent();
            //testing purposes
            useridTextBox.Text = "John@speechmobility.com";
            passwordTextBox.Text = "John99$";
            this.viewPassword.Checked = true;
            passwordTextBox.PasswordChar = '\0';
        }

        //method to laod database data
        private void loadData()
        {

            userCbContext.PersonalInformations
                .Load();
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
            email = useridTextBox.Text;
            password = passwordTextBox.Text;

            if (isEmailValid())
            {
                //to save fromcreating a new Form object,kwe pass the refenrence of this form to the method.
                Form currentForm = this;
                DbConnection readData = new DbConnection(USER_DB_CONNECTION_STRING, email, password);
                readData.readPersonalInformation(currentForm);

            }
        }

        private bool isEmailValid()
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void viewPassword_CheckedChanged(object sender, EventArgs e)
        {
            

            if (viewPassword.Checked == true && viewPassword.Focused)
            {
                passwordTextBox.PasswordChar = '\0'; 
            }
            else if (viewPassword.Checked == false)
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
