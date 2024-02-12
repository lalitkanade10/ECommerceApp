using AutoMapper;
using ECommerce.Repository.Repositories.Master.Interface;
using ECommerce.Repository.Repositories.Master.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository
{
    public static class ConfigurationRepository
    {
        public static void AddConfigurationRepository(this IServiceCollection services)
        {
            services.AddTransient<IDepartmentMasterRepository, DepartmentMasterRepository>();
            services.AddTransient<ICategoryMasterRepository, CategoryMasterRepository>();
            services.AddTransient<IUnitMasterRepository, UnitMasterRepository>();
            services.AddAutoMapper();
        }
    }
}
