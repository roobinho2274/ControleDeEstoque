namespace InventoryControlPlus.Domain.Repositories;

public interface ISupplierRepository
{
    Task<Supplier?> GetByIdAsync(int id);
    Task AddAsync(Supplier entity);
    void DeleteAsync(int id);
    Task<bool> SaveChangesAsync();
}