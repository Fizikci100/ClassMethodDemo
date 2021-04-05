using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        public void Add(Customer customer)
        {
            Console.WriteLine("Congratulations, " + customer.CustomerFirstName +" "+ customer.CustomerMiddleName +" "+ customer.CustomerLastName + ". Your registration is completed.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("We are sorry for that, " + customer.CustomerFirstName +" "+ customer.CustomerMiddleName +" "+ customer.CustomerLastName + ". Your registration has been deleted. We hope to see you again.");
        } 

        public void List(Customer[] customers)
        {
            foreach (Customer c in customers)
            {
                Console.WriteLine(c.CustomerId);
                Console.WriteLine(c.CustomerFirstName);
                Console.WriteLine(c.CustomerMiddleName);
                Console.WriteLine(c.CustomerLastName);
                Console.WriteLine(c.CustomerEmailAddress);
                Console.WriteLine(c.CustomerPhoneNummer);

                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Customers listed.");

        }



    }
}
