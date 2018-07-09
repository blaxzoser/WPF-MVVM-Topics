using Sample.Entities;
using Samples.MVVM.Library;
using Samples.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class HiarchicalDataTemplatesScenarioViewModel : BindableBase
    {
        public ObservableCollection<Company> Companies { get; set; }

        public ICompany CompanyRepository { get; set; }

        public HiarchicalDataTemplatesScenarioViewModel()
        {
            this.CompanyRepository = new MemoryCompanyRepository();
            this.Companies = new ObservableCollection<Company>(this.CompanyRepository.GetAll());
        }



    }
}
