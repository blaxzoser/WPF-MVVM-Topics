using Sample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Repository
{
    public interface ICompany
    {
        void Add(Company company);
        Company Get(int CompanyID);
        List<Company> GetAll();
        void Delete();
        void Update(Company compan);
    }
}
