using Prism.Modularity;
using Prism.Regions;
using Sample.MVVM.Prism.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.MVVM.Prism.ViewModule
{
    public class HelloWorldViewModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;
        public HelloWorldViewModule(IRegionViewRegistry registry)
        {
            this.regionViewRegistry = registry;
        }
        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion("MainRegion", typeof(HelloWorldView));
        }
    }
}
