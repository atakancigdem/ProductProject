using ProductProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.DataAccess.Entity
{
    class DatabaseLoggerManager : ICustomerLoggerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşteri veritabanına loglandı.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşteri veritabanından silindi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşteri veritabanında güncellendi.");
        }
    }
}
