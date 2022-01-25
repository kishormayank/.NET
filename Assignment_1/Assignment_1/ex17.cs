using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string: ");
            String str= Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string str2 = new string(charArray);
            Console.WriteLine("reverse is: "+ str2);

            Console.ReadKey();
        }
    }
}
