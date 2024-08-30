using solid_Train.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_Train.Methods
{
    internal class EmailClient
    {
        public void SendEmail(Account account , string mss ,decimal amount)
        {
            account.Balance += amount;
            mss = $"To: {account.Email}\nSubject: Deposit Successful\n\nDear {account.Name},\n\nYour deposit of {amount:C} was successful! Your new balance is {account.Balance:C}.\n\nBest regards,\nYour Bank";

            Console.WriteLine(mss);
        }
    }
}
