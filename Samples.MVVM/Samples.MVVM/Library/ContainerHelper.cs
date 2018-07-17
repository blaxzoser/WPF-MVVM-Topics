using Samples.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace Samples.MVVM.Library
{
    public static class ContainerHelper
    {
        private static IUnityContainer _container;
        static ContainerHelper()
        {
            _container = new UnityContainer();
            _container.RegisterType<IProduct, ProductRepository>(new ContainerControlledLifetimeManager());

        }
        public static void RegisterType<T>()
        {
             _container.RegisterType<T>();
        }

        public static T ResolveAll<T>()
        {
            return _container.Resolve<T>();
        }

        public static IUnityContainer Container
        {
            get { return _container; }
        }
    }
}
