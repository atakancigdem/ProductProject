using ProductProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.DataAccess.Abstract
{
    interface IProductLoggerService
    {
        void Add(Product product);
        void Delete(Product product);
    }
}
