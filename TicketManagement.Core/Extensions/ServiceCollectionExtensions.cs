using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicketManagement.Core.Concrete.EntityFramework.Context;

namespace TicketManagement.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddDataAccessModule(this IServiceCollection services, IConfiguration configurationContext)
    {
        services.AddDbContext<TicketContext>(options => options.UseSqlServer(configurationContext["connectionString"]), ServiceLifetime.Singleton);
    }
}