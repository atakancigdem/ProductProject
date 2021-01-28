using ProductProject.Business.Abstract;
using ProductProject.Business.Entity;
using ProductProject.DataAccess.Entity;
using ProductProject.Entites;
using System;

namespace ProductProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { FirstName = "Atakan", LastName = "Çiğdem", BirthYear = 2001, NationlityId = "121212", Id = 1 };
            Customer customer2 = new Customer() { FirstName = "Melek", LastName = "Gül", BirthYear = 1975, NationlityId = "131313", Id = 2 };
            Customer customer3 = new Customer() { FirstName = "Furkan", LastName = "Çiğdem", BirthYear = 1991, NationlityId = "141414", Id = 3 };

            Product product1 = new Product() { Name = "Pantolon", Price = 90, StockNumber = 10, Id = 1 };
            Product product2 = new Product() { Name = "Gömlek", Price = 70, StockNumber = 12, Id = 2 };
            Product product3 = new Product() { Name = "Tişört", Price = 50, StockNumber = 8, Id = 3 };
            Product product4 = new Product() { Name = "Ayakkabı", Price = 100, StockNumber = 15, Id = 4 };

            CustomerManager customer = new CustomerManager(new ValidateManager(), new DatabaseLoggerManager());
            ProductManager product = new ProductManager(new FileLoggerManager());
            PurchaseManager purchase = new PurchaseManager();

            customer.Add(customer1);
            customer.Add(customer2);
            customer.Add(customer3);
            
            product.Add(product1);
            product.Add(product2);
            product.Add(product3);
            product.Add(product4);

            purchase.Buy(customer1, product2);
            purchase.Buy(customer3, product2);
            purchase.Restitute(customer1, product1);
        }
    }
}
