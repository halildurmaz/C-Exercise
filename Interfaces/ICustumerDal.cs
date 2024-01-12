using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustumerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustumerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated!");
        }

    }
    class OracleCustomerDal : ICustumerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated!");
        }
    }
    class MySqlCustomerDal : ICustumerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated!");
        }
    }

    class CustomerManager
    {
        public void Add(ICustumerDal custumerDal)
        {

            custumerDal.Add();
        }
    }
}
