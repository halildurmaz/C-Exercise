﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();

            database.Add();
            database.Delete();

            Database database1 = new MySql();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default!");
        }
        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Added by SqlServer!");
        }
    }

    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Added by MySql!");
        }
    }
}
