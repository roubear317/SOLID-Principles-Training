using solid_Train.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_Train.Methods
{
    internal class Deposit
    {
        public void DepositClient(Account account ,string mss , decimal amount)
        {

            mss = $"To: {account.Email}\nSubject: Transaction Failed\n\nDear {account.Name},\n\nYour withdrawal request of {Math.Abs(amount):C} has failed due to insufficient funds. Your current balance is {account.Balance:C}.\n\nBest regards,\nYour Bank";
        }
    }
}
