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
    public partial class SignUpForm : Form
    {
        //Create dbcontext for users
        private CryptoWallet.UsersEntities userCbContext =
            new CryptoWallet.UsersEntities();

        private readonly string USER_DB_CONNECTION_STRING = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Users.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        private string first;
        private string last;
        private string email;
        private int age;
        private string password;


        public SignUpForm()
        {
            InitializeComponent();
        }

        //method to laod database data
        private void loadData()
        {

            userCbContext.PersonalInformations
                .Load();
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            first = firstNameTextbox.Text;
            last = lastNameTextbox.Text;
            email = emailTextbox.Text;
            age = ageComboBox.SelectedIndex;
            password = passwordTextBox.Text;

            //USer conenctionstring: data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Users.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"

            //Crypto connectionstring: data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Crypto.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"

            if (isEmailValid())
            {
                User user = new User(first, last, email, age, password);

                if (first.Length == 0 || last.Length == 0 || email.Length == 0 ||
                    age.ToString().Length == 0 || password.Length == 0)
                {
                    MessageBox.Show("One or more textbox is empty.");
                }
                else
                {
                    try
                    {
                        DbConnection userdb = new DbConnection(USER_DB_CONNECTION_STRING, first, last, email, age, password);
                        userdb.insertPersonalInformation();
                        userdb.insertBankingInformation();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
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
    }
}
