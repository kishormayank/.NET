using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class i
    {
        static void Main(string[] args)
        {
            
            StringBuilder obj = new StringBuilder("The quick brown fox jumps over the lazy dog");
          
           obj.Replace("The", "A");
            Console.WriteLine(obj);

            Console.ReadKey();
        }
    }
}
