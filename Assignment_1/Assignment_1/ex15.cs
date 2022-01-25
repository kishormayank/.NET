using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class ex15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 10 marks: ");
            int []arr=new int[10];
            for(int i=0; i<arr.Length; i++)
                arr[i]=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int min = arr[0];
            int max = arr[0];
            foreach(int i in arr)
            {
                sum += i;
                if(min>i)
                    min = i;
                if(max<i)
                    max = i;
            }
          
            Console.WriteLine("sum is: "+ sum);
            Console.WriteLine("average is " + sum/10);
            Console.WriteLine("minimun & maximum marks is: " + min + " & " + max);
            Array.Sort(arr);
            Console.WriteLine(" marks in ascending order: ");
            foreach(int i in arr)
                Console.WriteLine(i);
            Array.Reverse(arr);
            Console.WriteLine(" marks in descending order: ");
            foreach (int i in arr)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
