using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects
{
    class Student
    {
        public int roll;
        public string name;
        public double MarksInEng;
        public double MarksInMaths;
        public double MarksInScience;

        public void display()
        {
            Console.WriteLine("Student name & roll: "+name+"  "+ roll);
            double sum = MarksInEng + MarksInMaths + MarksInScience;
            Console.WriteLine("Total marks: "+sum);
            double percent = (sum / 300) * 100;
            Console.WriteLine("percent: "+percent+" %");
        }
    
    }
    internal class ex5
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("enter name roll and marks in eng maths & science: ");
            st.name=Console.ReadLine();
            st.roll=int.Parse(Console.ReadLine());
            st.MarksInEng=double.Parse(Console.ReadLine());
            st.MarksInMaths=double.Parse(Console.ReadLine());   
            st.MarksInScience=double.Parse(Console.ReadLine());

            st.display();
            Console.ReadKey();

        }
    }
}
