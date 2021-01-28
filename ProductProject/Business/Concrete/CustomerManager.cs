using ProductProject.Business.Abstract;
using ProductProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject.Business.Entity
{
    class CustomerManager : ICustomerService
    {
        IValidateService _validateServices;
        ICustomerLoggerService _loggerServices; 

        public CustomerManager(IValidateService validateServices, ICustomerLoggerService loggerServices)
        {
            _validateServices = validateServices;
            _loggerServices = loggerServices;
        }

        public void Add(Customer customer)
        {
            if(_validateServices.Validate(customer)== true)
            {
                Console.WriteLine( customer.FirstName + " " + customer.LastName + " Doğrulamadan Geçti.\nKayıt Olundu");
                _loggerServices.Add(customer);
            }
            else
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " Doğrulamdan Geçemedi.\nKayıt Olunamadı.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Kayıttan Silindi");
            _loggerServices.Delete(customer);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Kayıdı Güncellendi");
            _loggerServices.Update(customer);
        }
    }
}
