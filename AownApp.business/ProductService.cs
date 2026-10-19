using AownApp.dataaccess;
using AownApp.Models;

namespace AownApp.business
{
    public class ProductService : IProductService
    {
        private readonly IProductDal _dal;

        public ProductService(IProductDal dal)
            => _dal = dal;

        public Task<List<ProductModel>> GetAllAsync() => _dal.GetAllAsync();
        public Task AddAsync(ProductModel product) => _dal.AddAsync(product);
        public Task UpdateAsync(ProductModel product) => _dal.UpdateAsync(product);
        public Task DeleteAsync(Guid id) => _dal.DeleteAsync(id);
    }
}