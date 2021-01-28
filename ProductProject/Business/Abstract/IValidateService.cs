using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.Business.Abstract
{
    interface IValidateService
    {
        bool Validate(Customer customer);
    }
}
