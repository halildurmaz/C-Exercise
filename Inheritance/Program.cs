using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {


        static void Main(string[] args)
        {


            Person1 worker = new Worker();
           
            worker.Add();
            worker.Add1();

            Console.WriteLine(Hata.hata1); 



            Person[] person = new Person[3] {
                new Person
                {
                    FirstName = "Halil"
                } ,
                new Customer
                {
                    FirstName = "Enes"
                } ,
                new Student
                {
                    FirstName = "Mami"
                }
            };

            foreach (var item in person)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departman { get; set; }
    }
}
