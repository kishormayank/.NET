using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassAndObjects_2
{
    class Student1
    {
        public int roll;
        public string name;
        public double MarksInEng;
        public double MarksInMaths;
        public double MarksInScience;

        public Student1()
        {
            Console.WriteLine("enter name roll and marks in eng maths & science: ");
            name = Console.ReadLine();
            roll = int.Parse(Console.ReadLine());
            MarksInEng = double.Parse(Console.ReadLine());
            MarksInMaths = double.Parse(Console.ReadLine());
            MarksInScience = double.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Student name & roll: " + name + "  " + roll);
            double sum = MarksInEng + MarksInMaths + MarksInScience;
            Console.WriteLine("Total marks: " + sum);
            double percent = (sum / 300) * 100;
            Console.WriteLine("percent: " + percent + " %");
        }
    }
    internal class ex3
    {
        static void Main(string[] args)
        {

            Student1[] obj = new Student1[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Student: "+i+1);
                obj[i] = new Student1();  
            }
            foreach(Student1 s in obj)
            {
                Console.WriteLine("Student: " + s.roll);
                s.display();
                Console.WriteLine();
            }
            
            Console.ReadKey();

        }
    }
}
