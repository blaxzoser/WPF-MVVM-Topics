using Sample.Entities;
using Sample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Repository
{
    public class MemoryRepository : ICustomer
    {
        List<Customer> Customers = new List<Customer>();
        List<Nationality>  Nationalities = new List<Nationality>();
        public MemoryRepository()
        {
            Customers.Add(new Customer() { LastName = "Pintado Goicochea", Name = "Luis", Phone = 234234 });
            Customers.Add(new Customer() { LastName = "Perez GOdinez", Name = "Maria", Phone = 45678923 });
            Customers.Add(new Customer() { LastName = "Mercado Ortiz", Name = "Julieta", Phone = 956786547 });

            Nationalities.Add(new Nationality() { Description = "Asia", NationalityID = 1 });
            Nationalities.Add(new Nationality() { Description = "Africa", NationalityID = 0 });
            Nationalities.Add(new Nationality() { Description = "Europe", NationalityID = 2 });
            Nationalities.Add(new Nationality() { Description = "Oceania", NationalityID = 3 });
            Nationalities.Add(new Nationality() { Description = "IT", NationalityID = 4 });
        }
        public void Add(Customer customer)
        {
            Customers.Add(customer);

        }

        public List<Customer> Get()
        {
            return Customers;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public List<Nationality> GetAllNationalities()
        {        
            return Nationalities;
        }

        public void Delete(Customer customer)
        {
            Customers.Remove(customer);
        }
    }
}
