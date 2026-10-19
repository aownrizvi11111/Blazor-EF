using AownApp.Models;

namespace AownApp.business
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetAllAsync();
        Task AddAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task DeleteAsync(Guid id);
    }
}