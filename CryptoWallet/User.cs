using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    class User
    {
        private string Email { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private string Password { get; set; }

        public User(string firtsName, string lastName, string email, int age, string password)
        {
            Email = email;
            FirstName = firtsName;
            LastName = lastName;
            Age = age;
            Password = password;
        }

        public int Withdraw()
        {
            return 0;
        }

        public void Deposit()
        {

        }

        public int Transfer()
        {
            return 0;
        }
    }
}
