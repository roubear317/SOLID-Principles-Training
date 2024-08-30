using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace solid_Train.Module
{
    internal class Account
    {

        public string Name { get; set; }


        public string Email { get; set; }
        public decimal Balance { get; set; }


        public Account(string Name, string Email, decimal Balance)
        {
            this.Name = Name;
            this.Email = Email;
            this.Balance = Balance;

        }

      






    }
}
