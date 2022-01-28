using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassAndObjects_2
{
    internal class Program
    {
        class Account1
        {
            public int Accountno;
            public string CustomerName;
            public string AccountType;
            public int balance;

            public Account1()
            {
                Console.WriteLine("enter account number, name, account type: ");
                Accountno = Convert.ToInt32(Console.ReadLine());
                CustomerName = Console.ReadLine();
                AccountType = Console.ReadLine();

                Console.WriteLine("Enter balance: ");
                balance = int.Parse(Console.ReadLine());
            }
            public void credit(int amt)
            {
                Console.WriteLine("amount deposited!");
                balance += amt;
            }
            public void debit(int amt)
            {
                Console.WriteLine("current bal: " + balance);
                balance -= amt;
                Console.WriteLine("amount withdrawn!");
                Console.WriteLine("balance after withdrawal: " + balance);
            }
            public void show()
            {
                Console.WriteLine("account number: " + Accountno);
                Console.WriteLine("customer name: " + CustomerName);
                Console.WriteLine("Account type: " + AccountType);
                Console.WriteLine("balance: Rs." + balance);
            }
        }
        static void Main(string[] args)
        {
            Account1 account1 = new Account1();
            Console.WriteLine("Choose action (D/W): ");
            char action = char.Parse(Console.ReadLine());
            switch (action)
            {
                case 'D':
                    Console.WriteLine("enter amount to de deposited");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    account1.credit(amt);
                    break;
                case 'W':
                    Console.WriteLine("enter amount to be withdrawn");
                    int amt1 = Convert.ToInt32(Console.ReadLine());
                    account1.debit(amt1);
                    break;
                default:
                    Console.WriteLine("no action done");
                    break;
            }
            Console.WriteLine();
            account1.show();
            Console.ReadKey();

        }
    }
}
