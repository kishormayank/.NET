using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class c
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";
            str=string.Concat(str," and killed it");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
