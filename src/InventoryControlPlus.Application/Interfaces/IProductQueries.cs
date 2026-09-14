public interface IProductQueries
{
    Task<ProductDto?> GetProductByIdAsync(int productId);
    Task<IEnumerable<ProductDto>> GetAllProductsAsync();
}