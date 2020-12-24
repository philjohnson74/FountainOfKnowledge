using Fountain.Application.Interfaces;
using Fountain.Application.Services;
using Fountain.Domain.CommandHandlers;
using Fountain.Domain.Commands;
using Fountain.Domain.Core.Bus;
using Fountain.Domain.Interfaces;
using Fountain.Infrastructure.Bus;
using Fountain.Infrastructure.Data.Context;
using Fountain.Infrastructure.Data.Repository;
using MediatR;
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
            services.AddScoped<IMediatorHandler, InMemoryBus>();
            services.AddScoped<IRequestHandler<CreatePenCommand, bool>, PenCommandHandler>();
            services.AddScoped<IPenService, PenService>();
            services.AddScoped<IPenRepository, PenRepository>();
            services.AddScoped<FountainDBContext>();
        }
    }
}
