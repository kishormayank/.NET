using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    interface IGovtRules
    {
        double EmployeePF(double basicSalary);
        void leavedetails();
        double GratuityAmount(int serviceCompleted,double basicSalary);
    }
    class TCS: IGovtRules
    {
        string epid;
        string name;
        string designation;
        double basicSal;
        int serviceyears;
        public TCS(string ep, string n, string desig, double sal)
        {
            this.epid = ep;
            this.name = n;
            this.designation = desig;
            this.basicSal = sal;
        }
        public double EmployeePF(double basicSal)
        {
            double totalPF;
            totalPF = 0.12 * basicSal + 0.0833 * basicSal;
            return totalPF;
        }
        public void leavedetails()
        {
            Console.WriteLine("LEAVES: 1 day CL per month \n 12 days sick leave per year \n 10 days of priveledge leave per year ");
        }

        public double GratuityAmount(int serviceCompleted, double basicSal)
        {
            double amt;
            if (serviceCompleted >= 10 && serviceCompleted < 20)
            {
                amt = 2 * basicSal;
            }
            else if (serviceCompleted >= 20)
            {
                amt = 2 * basicSal;
            }
            else
                amt = 0.00;
            return amt;
        }
    }
    class Accenture: IGovtRules
    {
        string epid;
        string name;
        string designation;
        double basicSal;
        int serviceyears;
        public Accenture(string ep, string n, string desig, double sal)
        {
            this.epid = ep;
            this.name = n;
            this.designation = desig;
            this.basicSal = sal;
        }
        public double EmployeePF(double basicSal)
        {
            double totalPF;
            totalPF = 0.12 * basicSal + 0.12 * basicSal;
            return totalPF;
        }
        public void leavedetails()
        {
            Console.WriteLine(" LEAVES: 2 days CL per month \n 5 days sick leave per year \n 5 days of priveledge leave per year ");
        }
      public  double GratuityAmount(int serviceCompleted, double basicSalary)
        {
            return basicSalary;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter epid, employee name, designation, basicsalary & service years of employee");
            string epid = Console.ReadLine();
            string name=Console.ReadLine();
            string designation=Console.ReadLine();
            double basicSal=double.Parse(Console.ReadLine());
            int serviceyears=int.Parse(Console.ReadLine());

            IGovtRules obj= new TCS(epid, name, designation, basicSal);
            IGovtRules obj1= new Accenture(epid, name, designation, basicSal);


            Console.WriteLine("Enter company name: ");
            String company=Console.ReadLine();
            if (company == "TCS")
            {
                double PF = obj.EmployeePF(basicSal);
                Console.WriteLine("PF: " + PF + " \n" + "Gratuity: " + obj.GratuityAmount(serviceyears, basicSal));
               obj.leavedetails();
            }
            else if(company =="Accenture")
            {
               
                double PF = obj1.EmployeePF(basicSal);
                Console.WriteLine("PF: " + PF);
                obj.leavedetails();
            }

            Console.ReadKey();

    

        }
    }
}
