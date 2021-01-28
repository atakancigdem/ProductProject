using ProductProject.Business.Abstract;
using ProductProject.DataAccess.Abstract;
using ProductProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.Business.Entity
{
    class ProductManager : IProductService
    {
        IProductLoggerService _productLoggerServices;
        public ProductManager(IProductLoggerService productLoggerServices)
        {
            _productLoggerServices = productLoggerServices;
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ürün Sisteme Eklendi.");
            _productLoggerServices.Add(product);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Ürün Sistemden Kaldırıldı.");
            _productLoggerServices.Delete(product);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Sistemde Güncellendi");
        }
    }
}
