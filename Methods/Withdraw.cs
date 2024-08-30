using solid_Train.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_Train.Methods
{
    internal class Withdraw
    {
        public void WithdrawClient(Account account ,string mss ,decimal amount)
        {

            account.Balance += amount;
            mss = $"To: {account.Email}\nSubject: Withdrawal Successful\n\nDear {account.Name},\n\nYour withdrawal of {Math.Abs(amount):C} was successful. Your new balance is {account.Balance:C}.\n\nBest regards,\nYour Bank";
            Console.WriteLine(mss);
        }

    }
}
