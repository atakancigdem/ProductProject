using ProductProject.Business.Abstract;
using ProductProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.Business.Entity
{
    class PurchaseManager : IPurchaseService
    {
        public void Buy(Customer customer, Product product)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + product.Name + " " + "Ürününü Satın Aldı.");
            Console.WriteLine("Ürünün Fiyatı : " + product.Price + "TL");
            product.StockNumber = product.StockNumber - 1;
            Console.WriteLine("{0} Ürününden {1} adet kaldı", product.Name, product.StockNumber);
        }

        public void Restitute(Customer customer, Product product)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + product.Name + " " + "Ürününü İade Etti.");
            product.StockNumber = product.StockNumber + 1;
            Console.WriteLine("{0} Ürününden {1} adet kaldı", product.Name, product.StockNumber);
        }
    }
}
