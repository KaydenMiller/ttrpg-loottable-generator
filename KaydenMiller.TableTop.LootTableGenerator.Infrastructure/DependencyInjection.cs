using KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;
using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence;
using KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence.Repositories;
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
            options.UseNpgsql("Host=localhost;Port=5432;Database=LootTableGenerator;Username=postgres;Password=ZAQ!2wsxZAQ!2wsx;"));

        services.AddScoped<IEquipmentRepository, EquipmentRepository>();
        services.AddScoped<ILootRepository, LootRepository>();
        services.AddScoped<IDescriptorRepository, DescriptorRepository>();

        return services;
    } 
}