using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            for(int i = a; i <= b; i++)            
                Console.WriteLine(i);

            
            
            Console.ReadKey();
            
        }

    }
}
