using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
       services.AddDbContext<InventoryContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("InventoryControlPlusConnection"),
            b => b.MigrationsAssembly(typeof(InventoryContext).Assembly.FullName)));

        //services.AddScoped<IPedidoRepository, PedidoRepository>();

        return services;
    }
}