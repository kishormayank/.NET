using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects
{
  
    
        class Account
        {
            public int Accountno;
            public string CustomerName;
            public string AccountType;
            public string TransactionType;
            public int amount;
            public int balance;
            public void credit(int amt)
            {
                balance += amt;
            }
            public void debit(int amt)
            {
                balance -= amt;
            }
            public void show()
            {
                Console.WriteLine("account number: " + Accountno);
                Console.WriteLine("customer name: "+CustomerName);
                Console.WriteLine("Account type: "+ AccountType);
                Console.WriteLine("balance: Rs." + balance);
            }
        }
    class Program 
    { 
        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine("enter account no, name of customer,  account type, transaction type(D/W)");
            account.Accountno=Convert.ToInt32(Console.ReadLine());  
            account.CustomerName=Console.ReadLine();
            account.AccountType=Console.ReadLine();
            account.TransactionType=Console.ReadLine();
            account.balance = 100000;

            switch (account.TransactionType)
            {
                case "D": Console.WriteLine("enter amount to de deposited");
                    account.amount=Convert.ToInt32(Console.ReadLine());
                    account.credit(account.amount);
                    break;
                case "W":Console.WriteLine("enter amount to be withdrawn");
                    account.amount = Convert.ToInt32(Console.ReadLine());
                    account.debit(account.amount);
                    break;
                default: Console.WriteLine("invalid operation");
                    break;
            }
            account.show();
            Console.ReadKey();
        }
    }
}
