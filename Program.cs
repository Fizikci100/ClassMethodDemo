using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //The information here is not real but imaginary.
            Customer customer1 = new Customer();
            customer1.CustomerId = 12;
            customer1.CustomerFirstName = "Ali";
            customer1.CustomerMiddleName = "Sadik";
            customer1.CustomerLastName = "Karakaya";
            customer1.CustomerEmailAddress = "Al_Sad@outlook.de";
            customer1.CustomerPhoneNummer = 0049162;
            customer1.CustomerCity = "Hannover";

            Customer customer2 = new Customer();
            customer2.CustomerId = 13;
            customer2.CustomerFirstName = "Einstein";
            customer2.CustomerMiddleName = " E =";
            customer2.CustomerLastName = "mc2";
            customer2.CustomerEmailAddress = "Eins_mc2@outlook.de";
            customer2.CustomerPhoneNummer = 0049163;
            customer2.CustomerCity = "Ulm";




            Customer[] customers = new Customer[] { customer1, customer2 };

            
            foreach (var c in customers)
            {
                Console.WriteLine(c.CustomerId);
                Console.WriteLine(c.CustomerFirstName);
                Console.WriteLine(c.CustomerMiddleName);
                Console.WriteLine(c.CustomerLastName);
                Console.WriteLine(c.CustomerEmailAddress);
                Console.WriteLine(c.CustomerPhoneNummer);

                Console.WriteLine("--------------------");

            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);

            Customer[] customer = new Customer[] { customer1, customer2 };
            customerManager.List(customers);


        }
    }
}
