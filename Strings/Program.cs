using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Halil";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            //sentence = "My name is İbrahim";
            bool result3 = sentence.EndsWith("h");
            bool result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.LastIndexOf(" ");
            var result7 = sentence.Insert(0, "Hello, ");
            var result8 = sentence.Substring(3, 4);
            var result9 = sentence.ToLower();
            var result10 = sentence.ToUpper();
            var result11 = sentence.Replace(" ", "-");
            var result12 = sentence.Remove(2);


            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.ReadLine();


        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);

            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
