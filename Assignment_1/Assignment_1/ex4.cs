using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Even number ");
            else
                Console.WriteLine("Odd number: ");
        }
    }
}
