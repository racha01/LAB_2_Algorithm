using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mydatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDB.showCustomer();
            MyDB.changeCustomerID();
            MyDB.showCustomer();
        }
    }
    class MyDB 
    {
        static int customerID = 100;
        static string strName = "Mr. chaiyo";
        static string address = "555, 55Rd.";

        public static void showCustomer() {
            Console.WriteLine("Customer ID is {0}", customerID);
            Console.WriteLine("Customer name is {0}", strName);
            Console.WriteLine("Customer address is {0}", address);
        }

        public static void changeCustomerID()
        {
            Console.Write("Please enter new Customer ID:");
            customerID = int.Parse(Console.ReadLine());
        }
    }
    
}

