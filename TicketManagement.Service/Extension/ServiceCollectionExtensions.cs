﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicketManagement.Core.Extensions;

namespace TicketManagement.Service.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessModule(this IServiceCollection services, IConfiguration configurationContext)
        {
            services.AddDataAccessModule(configurationContext);
        }
    }
}
