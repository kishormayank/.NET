using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class h
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string str1 = "The quick brown Fox jumps over the lazy Dog";
            Console.WriteLine(str.Contains(str1));

            Console.ReadKey();
        }
    }
}
