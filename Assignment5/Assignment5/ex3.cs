using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence: ");
            string str=Console.ReadLine();
            Dictionary<string, int> mylist = new Dictionary<string, int>();
            string[] arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (mylist.ContainsKey(arr[i]))
                {
                    mylist[arr[i]] = mylist[arr[i]] + 1;
                }
                else
                {
                    mylist.Add(arr[i], 1);
                }
            }
            Console.WriteLine("Number of times each word appeared in the sentence: ");
            foreach(string key in mylist.Keys)
            {
                Console.WriteLine(key+" "+ mylist[key]);
            }
            Console.ReadKey();
        }
    }
}
