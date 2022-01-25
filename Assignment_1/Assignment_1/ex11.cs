using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine());  
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(n+" * "+i+" = "+n*i);
            }
            Console.ReadKey();
        }
    }
}
