namespace InventoryControlPlus.Domain.Repositories;

public interface IMovimentRepository
{
    Task<Moviment?> GetByIdAsync(int id);
    Task AddAsync(Moviment moviment);
    void Delete(Moviment moviment);
    Task<bool> SaveChangesAsync();
}