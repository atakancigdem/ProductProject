using ProductProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.Business.Entity
{
    class ValidateManager : IValidateService
    {
        public bool Validate(Customer customer)
        {
            if (customer.FirstName == "Atakan" && customer.LastName == "Çiğdem" && customer.NationlityId == "121212" && customer.BirthYear == 2001 || 
                customer.FirstName == "Melek" && customer.LastName == "Gül" && customer.NationlityId == "131313" && customer.BirthYear == 1974 ||
                customer.FirstName == "Furkan" && customer.LastName == "Çiğdem" && customer.NationlityId == "141414" && customer.BirthYear == 1991)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
