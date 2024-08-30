using solid_Train.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace solid_Train.Methods
{
    internal class AccountServices
    {

        public void Maketransaction(Account account,decimal amount,EmailClient emailClient,Deposit deposit,Withdraw withdraw)
        {
            var transactionMessage = "";
            if (amount < 0)
            {

                if (account.Balance < Math.Abs(amount))
                {
                    transactionMessage = $"To: {account.Email}\nSubject: Transaction Failed\n\nDear {account.Name},\n\nYour withdrawal request of {Math.Abs(amount):C} has failed due to insufficient funds. Your current balance is {account.Balance:C}.\n\nBest regards,\nYour Bank";

                }
                else
                {
                    withdraw.WithdrawClient(account,transactionMessage,amount);
                  
                }
            }
            else
            {
                deposit.DepositClient(account, transactionMessage, amount);
                emailClient.SendEmail(account, transactionMessage, amount);
                

            }


            Console.WriteLine(transactionMessage);




        }


    }
}
