using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //Console.WriteLine(cities.Contains("Ankara"));
            
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, Name = "Halil" });
            //customers.Add(new Customer { Id = 2, Name = "Enes" });

            List<Customer> customers = new List<Customer>
            {
            new Customer { Id = 1, Name = "Halil" },
            new Customer { Id = 2, Name = "Enes" }
            };

            
            var customer = new Customer
            {
                Id = 1,
                Name = "Hakan"
            };

            customers.Add(customer);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=3,Name="Ahmet"},
                new Customer{Id=4,Name="Hasan"}
            });
            Console.WriteLine(customers.Contains(customer));

            //customers.Clear();



            foreach (var item in customers)
            {
                Console.WriteLine(item.Id + " " + item.Name);
            }

            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);

            Console.ReadLine();
        }

        private static void ArrayList()
        {
            //string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities = new string[3];
            //Console.WriteLine(cities[0]);

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            cities.Add("Duzce");
            Console.WriteLine(cities[4]);

            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
