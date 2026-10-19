using AownApp.Models;

namespace AownApp.dataaccess
{
    public interface IProductDal
    {
        Task<List<ProductModel>> GetAllAsync();
        Task AddAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task DeleteAsync(Guid id);
    }
}