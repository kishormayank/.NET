using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class d
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string[] parts = str.Split(' ');
            string lastWord = parts[parts.Length - 1];
            if (lastWord == "dog")
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            Console.ReadKey();
        }
    }
}
