using OnlineShoppingApp.Models.Dtos;

namespace OnlineShoppingApp.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
        Task<ProductDto> GetItem(int id);
    }
}
