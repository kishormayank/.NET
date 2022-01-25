using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers between 200 & 300 divisible by 7 are: ");
            for(int i = 200; i <= 300; i++)
            {
                if(i%7==0)
                    Console.Write(i+" ");
            }

            Console.ReadKey();

        }
    }
}
