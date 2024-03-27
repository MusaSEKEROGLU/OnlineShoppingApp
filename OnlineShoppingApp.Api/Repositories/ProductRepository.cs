using Microsoft.EntityFrameworkCore;
using OnlineShoppingApp.Api.Data;
using OnlineShoppingApp.Api.Entities;
using OnlineShoppingApp.Api.Repositories.Contracts;

namespace OnlineShoppingApp.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineShoppingContext _onlineShoppingContext;
        public ProductRepository(OnlineShoppingContext onlineShoppingContext)
        {
            _onlineShoppingContext = onlineShoppingContext;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await _onlineShoppingContext.ProductCategories.ToListAsync();
            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await _onlineShoppingContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await _onlineShoppingContext.Products.FindAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await _onlineShoppingContext.Products.ToListAsync();
            return products;
        }
    }
}
