using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddPersistence();
        return services;
    }

    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<LootTableGeneratorDbContext>(options =>
            options.UseSqlite("Data Source = LootTableGenerator.db"));

        return services;
    } 
}