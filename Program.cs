// See https://aka.ms/new-console-template for more information
using solid_Train.Methods;
using solid_Train.Module;

Account account = new Account("roubear","rob.atef@gmail.com",5000);


AccountServices services = new AccountServices();

EmailClient client = new EmailClient();

Deposit deposit = new Deposit();
Withdraw withdraw = new Withdraw();

Console.WriteLine("enter your operation");

Console.WriteLine("press 1 if you want to Deposit");

Console.WriteLine("press 2 if you want to Withdraw");
var operation =Console.ReadLine();
decimal amount = 0;

switch (operation)
{
    
    case "1":
        Console.Write("please enter your amount: ");
        amount = decimal.Parse(Console.ReadLine());

      
        break;

    case "2":
        Console.Write("please enter your amount: ");
        amount = -1* decimal.Parse(Console.ReadLine());
        break;
}



services.Maketransaction(account,amount, client, deposit, withdraw);
Console.WriteLine(account.Balance);
