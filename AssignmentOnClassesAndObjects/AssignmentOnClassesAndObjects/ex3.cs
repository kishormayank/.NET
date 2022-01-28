using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects
{
    class shapes
    {
        public void area(int l, int b)
        {
            Console.WriteLine("area of rect: " + l * b);
        }
        public void area(double r)
        {
            double ar = 3.14 * r * r;
            Console.WriteLine("area of circle: " + ar);
        }
        public void area(double b, double h)
        {
            double ar1 = 0.5 * b * h;
            Console.WriteLine("area of traingle: " + ar1);
        }
        public void area(int s)
        {
            Console.WriteLine("area of square: " + s * s);
        }

    }
    class ex3
    {
        static void Main(string[] args)
        {
            shapes sh = new shapes();
            sh.area(2, 3);
            sh.area(8.0);
            sh.area(2);
            sh.area(1.0, 3.0);
            Console.ReadKey();
        }
    }
}
