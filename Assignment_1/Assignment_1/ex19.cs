using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string str= Console.ReadLine();
            string s=string.Empty;
            for(int i=str.Length-1; i>=0; i--)
            {
                s+=str[i].ToString();
            }
            if (s == str)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("not a palindrome");

            Console.ReadKey();
        }
    }
}
