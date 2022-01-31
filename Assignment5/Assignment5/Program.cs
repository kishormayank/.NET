using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount invested and the earning you wish for 5% interest");
            double amt=double.Parse(Console.ReadLine());
            double earning=double.Parse(Console.ReadLine());
            double sum = amt;
            int time = 0;
            double ci = 0;
            while (sum <= earning)
            {
                ci = sum * 0.05;
                sum = sum + ci;
                time++;
            }
            Console.WriteLine("Total earning of {0} will be in {1} years", sum, time);
            Console.ReadKey();

        }
    }
}
