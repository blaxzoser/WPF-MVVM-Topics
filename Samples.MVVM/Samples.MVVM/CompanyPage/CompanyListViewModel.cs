using Sample.Entities;
using Samples.MVVM.Command;
using Samples.MVVM.Library;
using Samples.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.CompanyPage
{
    public class CompanyListViewModel : BindableBase
    {
        public ObservableCollection<Company>  Companies { get; set; }

        public RelayParameterCommand<Company> DeleteCommand { get; set; }
        public RelayParameterCommand<Company> DeleteSelectedCommand { get; set; }

        private ICompany _companyRepository;

   

        public CompanyListViewModel()
        {
            DeleteCommand = new RelayParameterCommand<Company>(OnDelete);
            DeleteSelectedCommand = new RelayParameterCommand<Company>(OnDeleteSelected);
            _companyRepository = new MemoryCompanyRepository();
            Companies = new ObservableCollection<Company>(_companyRepository.GetAll());
        }

        private void OnDelete(Company product)
        {
            Companies.Remove(product);
        }

        private void OnDeleteSelected(Company product)
        {
            Companies.Remove(product);
        }
    }
}
