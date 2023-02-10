using Microsoft.Extensions.DependencyInjection;

using MyProject.Services.Interfaces;

using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Context;

namespace MyProject.Services
{
    public static class Extentions
    {
        public static IServiceCollection AddServicesInjections(this IServiceCollection services)
        {
            services.AddRepositoryInjections();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserChildService, UserChildService>();
            services.AddScoped<IContext, DBContext>();

            services.AddAutoMapper(typeof(Mapping));

            return services;
        }
    }
}
