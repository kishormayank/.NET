using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class j
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string[] str1 = str.Split(' ');
            string s1 = "";
            string s2 = "";
            for(int i = 0; i <= 5; i++)
            {
                s1 += str1[i]+" ";
            }
            for(int i = 6; i < 9; i++)
            {
                s2 += str1[i]+" ";
            }
           
            Console.WriteLine(s1);
            Console.WriteLine(s2);
         


            Console.ReadKey();
        }
    }
}
