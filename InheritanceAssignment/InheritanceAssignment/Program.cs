using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{

    class Furniture
    {
        public int orderId;
        public DateTime orderDate;
        public string furnitureType;
        public int qty;
        public double amount;
        public string paymentMode;

        public virtual void GetData()
        {
            Console.WriteLine("Enter orderID, Order date, furniture type, quantity, payment mode: ");
            orderId=int.Parse(Console.ReadLine());
            orderDate=DateTime.Parse(Console.ReadLine());
            furnitureType=Console.ReadLine();
            qty=int.Parse(Console.ReadLine());
            paymentMode=Console.ReadLine();

        }

        public virtual void ShowData()
        {
            Console.WriteLine("Order ID, date, furniture type, quantity, payment mode: ");
            Console.WriteLine(orderId);
            Console.WriteLine(orderDate);
            Console.WriteLine(qty);
            Console.WriteLine(paymentMode);

        }

    }

    class Chair: Furniture
    {
        public string chairType;
        public string Chairpurpose;
        public double rate;

        public override void GetData()
        {
            Console.WriteLine("enter chairtype(wood, steel, plastic), chairpurpose, rate:");
            chairType=Console.ReadLine();
            Chairpurpose=Console.ReadLine();
            rate=double.Parse(Console.ReadLine());
        }

        public override void ShowData()
        {
            
            amount = qty * rate;
            Console.WriteLine("amount: " + amount);
        }

    }

    class cot : Furniture
    {
        public string cotType;
        public string capacity;
        public double rate;

        public override void GetData()
        {

            Console.WriteLine("enter chairtype, chairpurpose, rate:");
            cotType = Console.ReadLine();
           capacity = Console.ReadLine();
            rate = double.Parse(Console.ReadLine());
        }

        public override void ShowData()
        {
            amount = qty * rate;
            Console.WriteLine("amount: " + amount);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture obj = null;
            obj = new Furniture();
            obj.GetData();
            if(obj.furnitureType=="chair")
            {
                Chair obj1 = new Chair();
                obj1.GetData();
                obj1.ShowData();
            }
            else
            {
              cot obj2 = new cot();
                obj2.GetData();
                obj2.ShowData();
            }
            Console.ReadKey();
        }
    }
}
