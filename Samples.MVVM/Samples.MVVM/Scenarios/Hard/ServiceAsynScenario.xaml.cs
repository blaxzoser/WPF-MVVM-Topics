using Samples.MVVM.Library;
using Samples.MVVM.ViewModel;
using Samples.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using Unity.Lifetime;

namespace Samples.MVVM.Scenarios.Hard
{
    /// <summary>
    /// Interaction logic for ServiceAsynScenario.xaml
    /// </summary>
    public partial class ServiceAsynScenario : Window
    {
        private ServiceAsynScenarioViewModel _serviceAsynScenarioViewModel;
        public ServiceAsynScenario()
        {
            InitializeComponent();
            Load();
        }

        public  void Load()
        {
             ContainerHelper.Container.RegisterType<IFakeService, ServiceFake>(new ContainerControlledLifetimeManager());
            _serviceAsynScenarioViewModel = ContainerHelper.ResolveAll<ServiceAsynScenarioViewModel>();
            this.DataContext = _serviceAsynScenarioViewModel;
        }
    }
}
