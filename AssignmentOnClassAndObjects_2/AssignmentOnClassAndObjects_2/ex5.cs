using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassAndObjects_2
{
    class Person
    {
        public string Fname;
        public string Lname;
        public string email;
        public DateTime dob;
        
        public Person(string f, string l, string em, DateTime dob)
        {
            this.Fname = f;
            this.Lname = l;
            this.email = em;
            this.dob = dob;
        }
        public Person(string f, string l, string em)
        {
            this.Fname=f;
            this.Lname = l;
            this.email=em;
        }
        public Person(string f, string l, DateTime dob)
        {
            this.Fname = f;
            this.Lname = l;
            this.dob = dob;
        }
    }
    internal class ex5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st person's first name,last name, email, dob ");
            string f=Console.ReadLine();
            string l=Console.ReadLine();
            string e = Console.ReadLine();
            DateTime d=DateTime.Parse(Console.ReadLine());
            Person obj = new Person(f, l, e, d);

            Console.WriteLine("Enter 2nd person's first name,last name, email ");
            string fname1 = Console.ReadLine();
            string lname1 = Console.ReadLine();
            string email1 = Console.ReadLine();
            Person obj1 = new Person(fname1, lname1, email1);

            Console.WriteLine("Enter 3rd person's first name,last name, dob ");
            string fname2 = Console.ReadLine();
            string lname2 = Console.ReadLine();
            DateTime dob2 = DateTime.Parse(Console.ReadLine());
            Person Obj2=new Person(fname2, lname2, dob2);

            Console.WriteLine("Person 1 first name,last name, email, dob:: " + obj.Fname + ", " + obj.Lname + ", " + obj.email + ", " + obj.dob);
            Console.WriteLine("Person 2 first name,last name, email:: "+obj1.Fname+", "+obj1.Lname+", "+obj1.email);
            Console.WriteLine("Person 3 first name,last name, dob:: " + obj1.Fname + ", " + obj1.Lname + " ," + obj1.dob);
            Console.ReadKey();
        }
    }
}
