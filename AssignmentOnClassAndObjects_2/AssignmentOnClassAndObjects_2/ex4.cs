using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassAndObjects_2
{
    class book
    {
        public int isbn;
        public string bookname;
        public string bookauthor;
        public int quantity;
        public double price;

        public book()
        {
            Console.WriteLine("Enter book name, isbn, book author, quantity of books, price of book");
            bookname = Console.ReadLine();
            isbn = Convert.ToInt32(Console.ReadLine());            
            bookauthor = Console.ReadLine();
            quantity = Convert.ToInt32(Console.ReadLine());
            price = Convert.ToDouble(Console.ReadLine());

        }
        public void bill()
        {
            double amount = quantity * price;
            Console.WriteLine("Total bill amount: Rs." + amount);
        }
    }
    internal class ex4
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.bill();
            Console.ReadKey();
        }
    }
}
