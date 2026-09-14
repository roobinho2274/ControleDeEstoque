namespace InventoryControlPlus.Domain.Repositories;

public interface IProductRepository
{
    Task<Product?> GetByIdAsync(int id);
    Task AddAsync(Product entity);
    void DeleteAsync(int id);
    Task<bool> SaveChangesAsync(); 
}