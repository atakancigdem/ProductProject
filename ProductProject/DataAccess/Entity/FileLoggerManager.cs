using ProductProject.DataAccess.Abstract;
using ProductProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.DataAccess.Entity
{
    class FileLoggerManager : IProductLoggerService
    {
        public void Add(Product product)
        {
            Console.WriteLine( product.Name + " Ürün dosyaya loglandı.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.Name + " Ürün dosyadan silindi");
        }
    }
}
