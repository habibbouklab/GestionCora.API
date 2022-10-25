using Gestion.Cora.Restaurant.Application.Contracts;
using Gestion.Cora.Restaurant.Application.Implimentation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Cora.Restaurant.Application
{
    public static class RegisterApplicationService
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddTransient<IGererAssiettes, GererAssiettes>();
            return services;
        }
    }
}
