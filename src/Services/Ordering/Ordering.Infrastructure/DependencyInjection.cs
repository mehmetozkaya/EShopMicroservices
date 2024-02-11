using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices
        (this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database");

        //// Add services to the container.
        //services.AddDbContext<ApplicationDbContext>(options =>
        //    options.UseSqlServer(connectionString));

        //services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

        return services;
    }
}
