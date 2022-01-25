using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in farenheit: ");
            int temperature=int.Parse(Console.ReadLine());
            int celcius;
            celcius = (temperature - 32) * 5 / 9;
            Console.WriteLine(celcius);
            Console.ReadKey();
        }
    }
}
