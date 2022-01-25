using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 5; i <= n; i++)
            {
                sum += i * i * i;

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
