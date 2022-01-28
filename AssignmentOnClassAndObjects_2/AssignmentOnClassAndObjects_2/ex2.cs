using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassAndObjects_2
{
    class Student
    {
        public int roll;
        public string name;
        public double MarksInEng;
        public double MarksInMaths;
        public double MarksInScience;

        public Student(int r, string n, double Eng, double Math1, double MarksInScience)
        {
            this.roll = r;
            this.name = n;
            this.MarksInEng = Eng;
            this.MarksInMaths = Math1;
            this.MarksInScience = MarksInScience;
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
        internal class ex2
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("enter name roll and marks in eng maths & science: ");
            string name = Console.ReadLine();
            int roll = int.Parse(Console.ReadLine());
            double MarksInEng = double.Parse(Console.ReadLine());
            double MarksInMaths = double.Parse(Console.ReadLine());
            double MarksInScience = double.Parse(Console.ReadLine());
            Student st = new Student(roll,name,MarksInEng,MarksInMaths,MarksInScience);

            st.display();
            Console.ReadKey();

        }
    }
}
