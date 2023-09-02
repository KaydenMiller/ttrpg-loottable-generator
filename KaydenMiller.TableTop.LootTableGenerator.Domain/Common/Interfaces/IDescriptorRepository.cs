using KaydenMiller.TableTop.LootTableGenerator.Domain.DescriptorAggregate;

namespace KaydenMiller.TableTop.LootTableGenerator.Domain.Common.Interfaces;

public interface IDescriptorRepository
{
    Task AddDescriptorAsync(Descriptor descriptor);
    Task<Descriptor> ReadDescriptorAsync(Guid descriptorId);
    Task UpdateDescriptorAsync(Descriptor descriptor);
}