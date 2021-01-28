using ProductProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.Business.Abstract
{
    interface IPurchaseService
    {
        void Buy(Customer customer, Product product);
        void Restitute(Customer customer, Product product);
    }
}
