using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount owed from credit card company: ");
            double M=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Monthly payment: ");
            double N=Convert.ToDouble(Console.ReadLine());
            double balance = M;
            double total = 0.00;
            int month = 0;
            while (total >= 0)
            {
                month++;
                balance = balance - N;
                total = balance * 0.015 + balance;
                Console.WriteLine("month: " + month);
                Console.WriteLine("balance: " + total);

            }
            Console.ReadKey();
        }
    }
}
