using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n= int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=n;i>0;i--)
            {
                fact *= i;
            }
            Console.WriteLine(fact);    
            Console.ReadKey();

        }
    }
}
