using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class f
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine("Checking for string " + str.ToUpper());
            string str2 = str.ToUpper();
            if (str2 == str)
                Console.WriteLine("strings are equal");
            else
                Console.WriteLine("strings are not equal");
            Console.ReadKey();
        }
    }
}
