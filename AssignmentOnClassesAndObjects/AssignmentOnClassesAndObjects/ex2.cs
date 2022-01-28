using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects
{
    class student
    {
        public int roll;
        public string name;
        public int sem;
        public string class1;
        public string branch;
        public int [] marks= new int[5];

        public student( )
        {
            //roll = obj.roll;
            //name = obj.name;
            //sem=obj.sem;
            //class1 = obj.class1;
            //branch = obj.branch;
            roll = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            sem = Convert.ToInt32(Console.ReadLine());
            class1 = Console.ReadLine();
            branch = Console.ReadLine();

        }
        public void displayresult(int [] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            double avg= sum / 5;
            int flag = 0;
            foreach(int i in arr)
            {
                if(i<35)
                {
                    Console.WriteLine("Failed");
                    flag = 1;
                    break;
                }

            }
            if(flag==0 && avg < 50)
            {
                Console.WriteLine("Failed");
            }
            else if (avg >= 50)
            {
                Console.WriteLine("Pass");
            }
        }
        public void display()
        {
            Console.WriteLine("roll:" + roll);
            Console.WriteLine("name: " + name);
            Console.WriteLine("sem: " + sem);
            Console.WriteLine("class: " + class1);
            Console.WriteLine("branch: " + branch);
        }

    }
    class ex2
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter roll, name, sem, class, branch: ");
            student obj1 = new student();
            
            Console.WriteLine("Enter the marks of 5 subjects: ");
            for (int i = 0; i < obj1.marks.Length; i++)
            {
                obj1.marks[i] =Convert.ToInt32(Console.ReadLine());
            }
            obj1.display();
            obj1.displayresult(obj1.marks);
            Console.ReadKey();
        }
}
}
