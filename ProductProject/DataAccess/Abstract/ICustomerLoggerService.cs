using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.DataAccess.Abstract
{
    interface ICustomerLoggerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
