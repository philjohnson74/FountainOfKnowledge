using Fountain.Application.Interfaces;
using Fountain.Application.Services;
using Fountain.Domain.Interfaces;
using Fountain.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fountain.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IPenService, PenService>();
            services.AddScoped<IPenRepository, PenRepository>();
        }
    }
}
