using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    interface SalesVal
    {
        double yearly_value();
    }
    abstract class Sales
    {
       public double daily_value;
        public abstract double monthly_val();
        public double daily_val()
        {
            return daily_value;
        }
    }
    internal class ex3: Sales, SalesVal
    {
        public double yearly_value()
        {
            double val = daily_value * 360; 
            return val;
        }
        public override double monthly_val()
        {
            double val1 = daily_value * 30;
            return val1;
        }

        static void Main(string[] args)
        {
            ex3 sales = new ex3();
           
            Console.WriteLine("Enter daily sales: ");
            sales.daily_value=double.Parse(Console.ReadLine());
            Console.WriteLine("Daily Sales: " + sales.daily_val());
            Console.WriteLine("Monthly Sales: "+ sales.monthly_val());
            Console.WriteLine("yearly Sales: " + sales.yearly_value());
            Console.ReadKey();
        }
    }
}
