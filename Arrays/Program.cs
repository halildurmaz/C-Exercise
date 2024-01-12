using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[4];
            students[0] = "Halil";
            students[1] = "Ibrahim";
            students[2] = "Muhammet";
            students[3] = "Enes";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[] students2 = { "Halil", "Muhammet", "Enes", "Basak" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[3, 3]
            {
                {"İst","İzmit","Balıkesir" },
                {"Zonguldak","trabzon","rize" },
                {"Muğla","Manisa","İzmir" },

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine("*************");
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                
            }

            Console.ReadLine();
        }
    }
}
