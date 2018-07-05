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
            Companies.Add(new Company() { CompanyID= 1, Name="tiempo development",  Budget=100000, NumberEmployes=400, Register= DateTime.Now   });
            Companies.Add(new Company() { CompanyID = 2, Name = "tiempo development 2", Budget = 200000, NumberEmployes = 500, Register = DateTime.Now });
            Companies.Add(new Company() { CompanyID = 3, Name = "tiempo development 3", Budget = 300000, NumberEmployes = 600, Register = DateTime.Now });
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
