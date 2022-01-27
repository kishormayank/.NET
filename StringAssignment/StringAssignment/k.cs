using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class k
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string[] str1 = str.Split(' ');
           
            string[]arr=new string[2];
            int i = 0;
            foreach (string str2 in str1)
            {
                if (str2 == "fox" || str2 == "dog")
                {
                    arr[i] = str2;
                    i++;
                }
            }
            foreach (string str2 in arr)
            {
                Console.WriteLine(str2);
            }

            Console.ReadKey();
        }
    }
}
