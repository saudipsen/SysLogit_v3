using SysLogit.Business.Contracts;
using SysLogit.Business.Services;
using SysLogit.Models;
using SysLogit.Repository.Contracts;
using SysLogit.Repository.Contracts.SysLogit.Repository.Contracts;
using SysLogit.Repository.Services;
using SysLogit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using Unity.Storage;

namespace SysLogit.Unity
{
    public static class UnityConfig
    {
        private static UnityContainer container = new UnityContainer();

        public static UnityContainer GetConfiguredContainer()
        {
            RegisterComponents();
            return container;
        }
        public static UnityContainer RegisterComponents()
        {

            // Register DbContext
            container.RegisterType<AppDbContext>();

            //Register contracts
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IShipmentRepository, ShipmentRepository>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IShipmentService, ShipmentService>();

            // Register forms
            container.RegisterType<ManageInventory>(new InjectionConstructor(typeof(IProductService)));
            container.RegisterType<ManageShipment>();
            container.RegisterType<Main>();

            return container;
        }
    }
}
