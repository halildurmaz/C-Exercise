using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int Id { get; set; }
        protected int Id2 { get; set; }
        public void Save()
        {
            //Id
        }

    }

    class Student : Customer
    {
        public void Save2()
        {
            //Id2
        }
    }

    public class Course
    {
        public string Name { get; set; }
    }
}
