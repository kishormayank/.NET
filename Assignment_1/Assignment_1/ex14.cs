using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex14
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter the 5 numbers: ");
            for (int i = 0; i < arr.Length; i++)
                arr[i]=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the smallest of the 5 numbers is: ");
            int min = arr[0];
            foreach(int i in arr)
            {
                if(min>i)
                    min = i;

            }
            Console.WriteLine(min); 

            Console.ReadKey();
        }
    }
}
