using Sample.Entities;
using Sample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Repository
{
    public class CustomerMockRepository : ICustomer
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Get()
        {
            List<Customer> newListMock = new List<Customer>();
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            newListMock.Add(new Customer() { Name = "MOCK 1", LastName = "MOCK LASTNAME", Phone = 123456789 });
            return newListMock;
        }

        public List<Nationality> GetAllNationalities()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
