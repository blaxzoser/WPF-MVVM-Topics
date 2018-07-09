using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Entities;

namespace Samples.Repository
{
    public class MemoryCompanyRepository : ICompany
    {
        List<Company> Companies = new List<Company>();
        public MemoryCompanyRepository()
        {

            var customerA = new Customer() { Name = "Luis", Comments="It's very good", Email="strato.bet@com", Gender=true, LastName="Pintado", Phone=5454};
            var customerB = new Customer() { Name = "Maria", Comments = "It's very nice", Email = "juanita.bet@com", Gender = false, LastName = "kiki", Phone = 123456789 };

            var customerC = new Customer() { Name = "Juan", Comments = "traveler", Email = "juan@com", Gender = true, LastName = "ter", Phone = 3333333 };
            var customerD = new Customer() { Name = "San", Comments = "good people", Email = "san@com", Gender = true, LastName = "Donpin", Phone = 1222222 };
            var customerE = new Customer() { Name = "Fake 2", Comments = "karate", Email = "fake@com", Gender = true, LastName = "fake", Phone = 11111111 };

            var customerF = new Customer() { Name = "fake 3", Comments = "Crossfiter", Email = "fabet@com", Gender = true, LastName = "chono", Phone = 78977894};


            var companyOne = (new Company() { CompanyID = 1, Name = "tiempo development", Budget = 100000, NumberEmployes = 400, Register = DateTime.Now });
            companyOne.Products = new List<Product>();

            var productA = new Product() { Cost=12, DateRegister= DateTime.Now, Description= "Product A", ProductID =1};
            productA.Customers = new List<Customer>();
            productA.Customers.Add(customerA);
            productA.Customers.Add(customerB);
            companyOne.Products.Add(productA);

            var companyTwo = new Company() { CompanyID = 2, Name = "tiempo development 2", Budget = 200000, NumberEmployes = 500, Register = DateTime.Now };
            companyTwo.Products = new List<Product>();

            var productB = new Product() { Cost = 12, DateRegister = DateTime.Now, Description = "Product B", ProductID = 2};
            productB.Customers = new List<Customer>();
            productB.Customers.Add(customerC);
            productB.Customers.Add(customerD);
            productB.Customers.Add(customerE);
            companyTwo.Products.Add(productB);

            var companyTree =  new Company() { CompanyID = 3, Name = "tiempo development 3", Budget = 300000, NumberEmployes = 600, Register = DateTime.Now };
            companyTree.Products = new List<Product>();

            var productC = new Product() { Cost = 3456, DateRegister = DateTime.Now, Description = "Product C", ProductID = 3 };
            productC.Customers = new List<Customer>();
            productC.Customers.Add(customerF);
            companyTree.Products.Add(productC);

            Companies.Add(companyOne);
            Companies.Add(companyTwo);
            Companies.Add(companyTree);
        }

        public void Add(Company company)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Company Get(int CompanyID)
        {
            return Companies.FirstOrDefault(source => source.CompanyID == CompanyID);
        }

        public List<Company> GetAll()
        {
            return Companies;
        }

        public void Update(Company compan)
        {
            throw new NotImplementedException();
        }
    }
}
