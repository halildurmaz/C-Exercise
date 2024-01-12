using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(4, 3);
            Console.WriteLine(result);

            int number1 = 75;
            int number2 = 48;
            int result1 = Add3(number1, number2);
            Console.WriteLine(result1);
            Console.WriteLine(Multiply(2, 5));
            Console.WriteLine(Multiply(2, 5, 9));

            Console.WriteLine(Add4(2,41,3,4,2,4));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 20)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return (number1 * number2);
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
