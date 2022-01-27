using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class p
    {
        static void Main(string[] args)
        {
            string str = @"";
            Console.WriteLine("enter the home directory for tomcat server: ");
            str+=Console.ReadLine();
            str = str + "/WebApps/MyApps/Images";
            Console.WriteLine(str);
            
            Console.ReadKey();
        }
    }
}
