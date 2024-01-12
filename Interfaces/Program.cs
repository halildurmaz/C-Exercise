using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //InterfacesIntro();
            //Demo();

            ICustumerDal[] custumerDals = new ICustumerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            foreach (var item in custumerDals)
            {
                item.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                Adress = "Istanbul",
                LastName = "Durmaz",
                Name = "Halil"
            };

            Student student = new Student
            {
                Id = 1,
                Name = "Enes",
                LastName = "Dursun",
                Department = "Bilgisayar Müh."
            };

            Worker worker = new Worker
            {
                Department = "It",
                Id = 1,
                LastName = "Sahin",
                Name = "Muhammet"
            };

            manager.Add(student);
            manager.Add(customer);
            manager.Add(worker);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name);
        }

    }
}
