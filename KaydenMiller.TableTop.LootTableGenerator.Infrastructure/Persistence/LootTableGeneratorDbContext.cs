using System.Reflection;
using KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Domain.EquipmentAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Domain.LootAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Domain.ModifierAggregate;
using KaydenMiller.TableTop.LootTableGenerator.Domain.RoomAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace KaydenMiller.TableTop.LootTableGenerator.Infrastructure.Persistence;

public class LootTableGeneratorDbContext : DbContext
{
    public DbSet<Equipment> Equipment { get; set; } = null!;
    public DbSet<Loot> Loot { get; set; } = null!;
    public DbSet<Descriptor> Descriptors { get; set; } = null!;
    public DbSet<Modifier> Modifiers { get; set; } = null!;
    public DbSet<LootTable> LootTables { get; set; } = null!;

    public LootTableGeneratorDbContext(DbContextOptions options) :
        base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
        base.OnModelCreating(modelBuilder);
    }
} 