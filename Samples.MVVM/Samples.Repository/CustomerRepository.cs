using System;
using System.Collections.Generic;
using Sample.Entities;

namespace Sample.Repository
{
    public class CustomerRepository : ICustomer
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public List<Customer> Get()
        {
            List<Customer> newList = new List<Customer>();
            newList.Add(new Customer() { LastName = "Pintado Goicochea", Name = "Luis", Phone = 234234 });
            newList.Add(new Customer() { LastName = "Perez GOdinez", Name = "Maria", Phone = 45678923 });
            newList.Add(new Customer() { LastName = "Mercado Ortiz", Name = "Julieta", Phone = 956786547 });
            return newList;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
