using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (RecorNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }

            HandleException(() =>
            {
                Find();
            });


            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<String> students = new List<String> { "Halil", "Enes", "Basak" };
            if (students.Contains("Ahmet"))
            {
                Console.WriteLine("Record Found!");
            }
            else
            {
                throw new RecorNotFoundException("Record not found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Halil", "Enes", "Mami" };
                students[3] = "Ahmet";

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                //Console.WriteLine(exception.InnerException); //exception details
            }
        }
    }
}
