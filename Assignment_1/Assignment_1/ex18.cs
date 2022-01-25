using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 words: ");
            string s1=Console.ReadLine();
            string s2=Console.ReadLine();
            if (s1 == s2)
                Console.WriteLine("strings are equal");
            else
                Console.WriteLine("not equal");

            Console.ReadKey();
        }
    }
}
