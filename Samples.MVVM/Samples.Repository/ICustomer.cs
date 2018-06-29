using Sample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Repository
{
    public interface ICustomer
    {
        List<Customer> Get();
        void Add(Customer customer);
        void Update();
        List<Nationality> GetAllNationalities();
        void Delete(Customer customer);
    }
}
