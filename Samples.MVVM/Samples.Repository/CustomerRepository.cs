using System;
using System.Collections.Generic;
using Sample.Entities;

namespace Sample.Repository
{
    public class CustomerRepository : ICustomer
    {

        public void Add(Customer customer)
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

        public List<Nationality> GetAllNationalities()
        {
            var list = new List<Nationality>();
            list.Add(new Nationality() { Description = "Asia" , NationalityID =1 });
            list.Add(new Nationality() { Description = "Africa", NationalityID = 0 });
            list.Add(new Nationality() { Description = "Europe", NationalityID = 2 });
            list.Add(new Nationality() { Description = "Oceania", NationalityID = 3 });
            list.Add(new Nationality() { Description = "IT", NationalityID = 4 });
            return list;
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
