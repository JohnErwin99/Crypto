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

        private string cryptoName;
        private int cryptoQty;
        private int cryptoPrice;


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

        public DbConnection(string url, int totalCrytoPrice)
        {
            connectionString = url;
            this.cryptoPrice = totalCrytoPrice;
        }

        //third 
        public DbConnection(string url, string email, string password)
        {
            connectionString = url;
            this.email=email;
            this.password=password;
        }

        public DbConnection(string url, string name, int quantity)
        {
            this.connectionString = url;
            this.cryptoName = name;
            this.cryptoQty = quantity;
        }

        public DbConnection(string url, string name, int price, int quantity)
        {
            this.connectionString = url;
            this.cryptoName = name;
            this.cryptoPrice = price;                   
            this.cryptoQty = quantity;
        }


        //INSERTS
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


                command.Parameters.AddWithValue("@id", 2);
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

        public void insertCryptoInformation()
        {
            string textQuery = "insert into CryptoInformation (UserId, Name,Price," +
                "Quantity) values (@id, @name, @price, @qty)";

            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                command.CommandType = CommandType.Text;
                command.CommandText = textQuery;


                command.Parameters.AddWithValue("@id", 1);
                command.Parameters.AddWithValue("@name", cryptoName);
                command.Parameters.AddWithValue("@price", cryptoPrice);
                command.Parameters.AddWithValue("@qty", cryptoQty);


                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"Cryto {cryptoName} was just bought at a price of {cryptoPrice}$ with a quantity of {cryptoQty}units :");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }

        }
        //READS
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
        public string readCryptoInformation()
        {
            string textQuery = "select Price from Inventory where Name='" + cryptoName + "'";
            string itemprice = "";
            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                SqlDataAdapter adpt = new SqlDataAdapter(command);
                con.Open();
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    itemprice =  dr["Price"].ToString();
                }
                con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return itemprice;
        }
        //reads debitamount
        public int readBankingInformation()
        {
            string textQuery = "select DebitBalance from BankingInformation where UserId='" + 1 + "'";
            int balanceLeftAmount = 0;
            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                SqlDataAdapter adpt = new SqlDataAdapter(command);
                command.CommandType = CommandType.Text;
                command.CommandText = textQuery;
                con.Open();
                DataTable dt = new DataTable();
                adpt.Fill(dt);

                balanceLeftAmount = Int32.Parse(dt.Rows[0]["DebitBalance"].ToString()) - cryptoPrice;
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            return balanceLeftAmount;
        }

        public int readBankingInformation2()
        {
            string textQuery = "select DebitBalance from BankingInformation where UserId='" + 1 + "'";
            int balanceLeftAmount = 0;
            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                SqlDataAdapter adpt = new SqlDataAdapter(command);
                command.CommandType = CommandType.Text;
                command.CommandText = textQuery;
                con.Open();
                DataTable dt = new DataTable();
                adpt.Fill(dt);

                balanceLeftAmount = Int32.Parse(dt.Rows[0]["DebitBalance"].ToString()) + cryptoPrice;
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            return balanceLeftAmount;
        }
        //reads cryptoAmount
        public int readBankingCryptoInformation()
        {
            string textQuery = "select CryptoBalance from BankingInformation where UserId='" + 1 + "'";
            int balanceLeftAmount = 0;
            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                SqlDataAdapter adpt = new SqlDataAdapter(command);
                command.CommandType = CommandType.Text;
                command.CommandText = textQuery;
                con.Open();
                DataTable dt = new DataTable();
                adpt.Fill(dt);

                balanceLeftAmount = Int32.Parse(dt.Rows[0]["CryptoBalance"].ToString()) - cryptoPrice;
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            return balanceLeftAmount;
        }


        //UPDATES

        public void updateBankingInformation(int remainingBalance)
        {
            string textQuery = "update BankingInformation set DebitBalance=@debit where UserId=@id";
            int balanceLeftAmount = remainingBalance;
            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                command.CommandType = CommandType.Text;
                command.CommandText = textQuery;
                con.Open();


                command.Parameters.AddWithValue("@id", 1);
                command.Parameters.AddWithValue("@debit", balanceLeftAmount);
                MessageBox.Show($"Balance updated:\n Remaining is: {balanceLeftAmount} $");
                command.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
       
        public void updateBankingCryptoInformation(int remainingBalance)
        {
            string textQuery = "update BankingInformation set CryptoBalance=@crypto where UserId=@id";
            int balanceLeftAmount = remainingBalance;
            try
            {
                SqlConnection con = new SqlConnection(@connectionString);
                SqlCommand command = new SqlCommand(textQuery, con);
                command.CommandType = CommandType.Text;
                command.CommandText = textQuery;
                con.Open();


                command.Parameters.AddWithValue("@id", 1);
                command.Parameters.AddWithValue("@crypto", balanceLeftAmount);
                MessageBox.Show($"Balance updated \n Remaining is: {balanceLeftAmount}$");
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }


    }
}
