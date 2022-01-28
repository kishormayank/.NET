using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects
{
    class Account1
    {
        public int Accountno;
        public string CustomerName;
        public string AccountType;
        public int balance;

        public void AssignVal()
        {
            Console.WriteLine("enter account number, name, account type: ");
            Accountno=Convert.ToInt32(Console.ReadLine());
            CustomerName=Console.ReadLine();
            AccountType=Console.ReadLine();

            Console.WriteLine("Enter balance: ");
            balance=int.Parse(Console.ReadLine());
        }
        public void credit(int amt)
        {
            Console.WriteLine("amount deposited!");
            balance += amt;
        }
        public void debit(int amt)
        {
            Console.WriteLine("amount withdrawn!");
            balance -= amt;
        }
        public void show()
        {
            Console.WriteLine("account number: " + Accountno);
            Console.WriteLine("customer name: " + CustomerName);
            Console.WriteLine("Account type: " + AccountType);
            Console.WriteLine("balance: Rs." + balance);
        }
    }
    internal class ex4
    {
        static void Main(string[] args)
        {
            Account1 account = new Account1();
            account.AssignVal();
            Console.WriteLine("Choose action (D/W): ");
            char action=char.Parse(Console.ReadLine());
            switch (action)
            {
                case 'D':
                    Console.WriteLine("enter amount to de deposited");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    account.credit(amt);
                    break;
                case 'W':
                    Console.WriteLine("enter amount to be withdrawn");
                    int amt1 = Convert.ToInt32(Console.ReadLine());
                    account.debit(amt1);
                    break;
                default:Console.WriteLine("no action done");
                    break;
            }
            Console.WriteLine();
            account.show();
            Console.ReadKey();
        }

    }
}
