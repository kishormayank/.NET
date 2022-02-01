using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    interface payable
    {
        double amt_due();
        void add_amt_due();

        string payment_address();
    }
    internal class ex2
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
