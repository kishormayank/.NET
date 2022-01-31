using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Building
    {
        public string type;
        public string capacity;
        public string dimension;
        public int floorNo;
        public DateTime dateOfCompletion;

        public Building()
        {
            Console.WriteLine("Enter type, capacity & date of completion: ");
            type=Console.ReadLine();
            capacity=Console.ReadLine();
            dateOfCompletion=DateTime.Parse(Console.ReadLine());
        }

        public void showdata()
        {
            Console.WriteLine("Type:  Capacity:  Date of completion: ",type+" "+ capacity+ " "+dateOfCompletion);
            if (type == "flat")
            {
                Console.WriteLine("Enter floor: ");
                floorNo=int.Parse(Console.ReadLine());
                Console.WriteLine("Flat is available at: ",+floorNo);
            }
            if (type == "villa")
            {
                Console.WriteLine("Enter dimension");
                dimension=Console.ReadLine();
                Console.WriteLine("dimensions are: " + dimension);
            }
        }
    }
    internal class ex2
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            building.showdata();
            Console.ReadKey();


        }
    }
}
