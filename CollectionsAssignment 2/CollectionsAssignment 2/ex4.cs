using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsAssignment_2
{
    class Program1
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = GetHashtable();
            int index = 0;
            int indexArea = -1;
            if (hashtable.ContainsKey("Perimeter"))
            {
                Console.WriteLine("The Hashtable contains the key perimeter");
            }
            else
            {
                Console.WriteLine("The Hashtable does not contain the key perimeter");
            }
            foreach (string key in hashtable.Keys)
            {
                if (hashtable.ContainsKey("Area"))
                {
                    indexArea = index;
                }
                index++;
            }
            if (indexArea != -1)
            {
                Console.WriteLine("The Hashtable with the key Area has index {0}", indexArea);
            }
            else
            {
                Console.WriteLine("The Hashtable does not contain the key Area");
            }

            Console.WriteLine();
            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine(string.Format("{0,-20} {1,-20}", key, hashtable[key]));
            }
            Console.WriteLine();
            if (hashtable.ContainsKey("Mortgage"))
            {
                hashtable.Remove("Mortgage");
                Console.WriteLine("The key having value Mortgage has been deleted.");
            }
            else
            {
                Console.WriteLine("The Hashtable does not contain the key Mortgage");
            }
            Console.WriteLine();
            foreach (string key in hashtable.Keys)
            {
                Console.WriteLine(string.Format("{0,-20} {1,-20}", key, hashtable[key]));
            }
            Console.ReadKey();

        }
        static Hashtable GetHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }
    }
}
