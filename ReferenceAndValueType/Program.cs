using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
           
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);



            string[] cities = new string[] { "Adana", "Ankara", "Afyon" };//101
            string[] cities1 = new string[] { "Balıkesir", "Bartın", "Bursa" };//101

            cities1 = cities;
            Console.WriteLine(cities1[0]);
            cities[0] = "İstanbul";
            Console.WriteLine(cities1[0]);


            DataTable dataTable = new DataTable();
            DataTable dataTable1;
            dataTable1 = dataTable;
            Console.ReadLine();
        }
    }
}
