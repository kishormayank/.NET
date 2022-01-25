using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 3 numbers: ");
            int a=Convert.ToInt32(Console.ReadLine());  
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Greater number is: ");
            if (a > b && a > c)
                Console.WriteLine(a);
            else if (b > c && b > a)
                Console.WriteLine(b);
            else
                Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
