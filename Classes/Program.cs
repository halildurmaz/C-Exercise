using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Halil"; //set blogu calisir
            customer.LastName = "Durmaz";
            customer.City = "Düzce";

            Customer customer1 = new Customer()
            {
                Id = 2,
                FirstName = "Dicle",
                LastName = "Vural",
                City = "İstanbul"
            };

            Console.WriteLine(customer1.FirstName); //get blogu calisir

            Console.ReadLine();
        }
    }

}
