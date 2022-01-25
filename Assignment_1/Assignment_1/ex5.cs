using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of numbers: ");
            int n= int.Parse(Console.ReadLine());
            int [] arr= new int[n];
            for(int i=0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int even = 0;
            int odd = 0;
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                    even++;
                else
                    odd++;
            }
            Console.WriteLine("even: " + even + "\nodd: " + odd);
            Console.ReadKey();
        }
    }
}
