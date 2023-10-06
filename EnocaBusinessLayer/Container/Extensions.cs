using EnocaBusinessLayer.Abctract;
using EnocaBusinessLayer.Concrete;
using EnocaDataAccessLayer.Abstract;
using EnocaDataAccessLayer.EntityFreamework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaBusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICarrierService, CarrierManager>();
            services.AddScoped<ICarrierDal, EfCarrierDal>();

            services.AddScoped<IOrdersService, OrdersManager>();
            services.AddScoped<IOrdersDal, EfOrdersDal>();

            services.AddScoped<ICarrierConfigrationsService, CarrierConfigurationsManager>();
            services.AddScoped<ICarrierConfigurationsDal, EfCarrierConfigurationsDal>();
        }
    }
}
