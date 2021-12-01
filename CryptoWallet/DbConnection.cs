using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoWallet
{
    internal class DbConnection
    {

        private string connectionString;
        private string fname;
        private string lname;
        private string email;
        private int age;
        private string password;

        private int debit;
        private int crypto;
        public DbConnection(string url, string fname, string lname, string email,
            int age, string password)
        {
            connectionString = url;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.age = age;
            this.password = password;
        }

        //second constructor
        public DbConnection(string url, int debit, int crypto)
        {
            connectionString = url;
            this.debit = debit; 
            this.crypto = crypto;
        }

        //third constructor
        public DbConnection(string url, string email, string password)
        {
            connectionString = url;
            this.email=email;
            this.password=password;
        }
        public void insertPersonalInformation()
        {
            string textQuery = "insert into PersonalInformation (UserId, FirstName,LastName," +
                "Email, Age, Password) values (@id, @fname, @lname, @email, @age, @pwd)";

            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                command.CommandType = CommandType.Text;
                command.CommandText = textQuery;


                command.Parameters.AddWithValue("@id", 0);
                command.Parameters.AddWithValue("@fname", fname);
                command.Parameters.AddWithValue("@lname", lname);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@pwd", password);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User is sucessfully created.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"");
            }
            
        }

        public void readPersonalInformation(Form previousform)
        {
            string textQuery = "select * from PersonalInformation where Email='"+ email +
                "' AND Password = '" + password+ "'";

            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                SqlDataAdapter adpt = new SqlDataAdapter(command);
                con.Open();
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    previousform.Hide();
                    HomeForm home = new HomeForm(email);
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect\nUsername or \nPassword!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void insertBankingInformation()
        {
            string textQuery = "insert into BankingInformation (UserId, DebitBalance, CryptoBalance" +
                ") values (@id, @debit,@crypto)";

            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                command.CommandType = CommandType.Text;
                command.CommandText = textQuery;


                command.Parameters.AddWithValue("@id", 0);
                command.Parameters.AddWithValue("@debit", debit);
                command.Parameters.AddWithValue("@crypto", crypto);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Transit is sucessfully saved.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }

        }


    }
}
