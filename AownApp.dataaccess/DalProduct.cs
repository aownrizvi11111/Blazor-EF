using AownApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AownApp.dataaccess
{
    public class DalProduct : IProductDal
    {
        private readonly IDbContextFactory<AppDbContext> _factory;

        public DalProduct(IDbContextFactory<AppDbContext> factory)
            => _factory = factory;

        public async Task<List<ProductModel>> GetAllAsync()
        {
            await using var db = await _factory.CreateDbContextAsync();
            return await db.Products
                .AsNoTracking()
                .OrderBy(p => p.Name)
                .ToListAsync();
        }

        public async Task AddAsync(ProductModel product)
        {
            await using var db = await _factory.CreateDbContextAsync();
            db.Products.Add(product);
            await db.SaveChangesAsync();
        }

        public async Task UpdateAsync(ProductModel product)
        {
            await using var db = await _factory.CreateDbContextAsync();
            db.Products.Update(product);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            await using var db = await _factory.CreateDbContextAsync();
            var product = await db.Products.FindAsync(id);
            if (product is null) return;

            db.Products.Remove(product);
            await db.SaveChangesAsync();
        }
    }
}