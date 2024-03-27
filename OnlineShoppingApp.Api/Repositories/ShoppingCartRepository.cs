using Microsoft.EntityFrameworkCore;
using OnlineShoppingApp.Api.Data;
using OnlineShoppingApp.Api.Entities;
using OnlineShoppingApp.Api.Repositories.Contracts;
using OnlineShoppingApp.Models.Dtos;

namespace OnlineShoppingApp.Api.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly OnlineShoppingContext _onlineShoppingContext;
        public ShoppingCartRepository(OnlineShoppingContext onlineShoppingContext)
        {
            _onlineShoppingContext = onlineShoppingContext;
        }

        private async Task<bool> CartItemExist(int cartId, int productId)
        {
            return await _onlineShoppingContext.CartItems.AnyAsync
                (c => c.CartId == cartId && c.ProductId == productId);
        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExist(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
            {
                var item = await (from product in _onlineShoppingContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = product.Id,
                                      Quantity = cartItemToAddDto.Quantity,

                                  }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await _onlineShoppingContext.CartItems.AddAsync(item);
                    await _onlineShoppingContext.SaveChangesAsync();
                    return result.Entity;
                }
            }

            return null;
        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await _onlineShoppingContext.CartItems.FindAsync(id);

            if (item != null)
            {
                _onlineShoppingContext.CartItems.Remove(item);
                await _onlineShoppingContext.SaveChangesAsync();
            }
            return item;
        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in _onlineShoppingContext.Carts
                         join cartItem in _onlineShoppingContext.CartItems
                         on cart.Id equals cartItem.CartId
                         where cartItem.Id == id
                         select new CartItem
                         {
                             Id = cartItem.Id,
                             ProductId = cartItem.ProductId,
                             Quantity = cartItem.Quantity,
                             CartId = cartItem.CartId
                         }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in _onlineShoppingContext.Carts
                          join cartItem in _onlineShoppingContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.CartId,
                              ProductId= cartItem.ProductId,
                              Quantity = cartItem.Quantity,
                              CartId= cartItem.CartId
                          }).ToListAsync();
        }

        public async Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            var item = await _onlineShoppingContext.CartItems.FindAsync(id);

            if (item != null)
            {
                item.Quantity = cartItemQtyUpdateDto.Quantity;
                await _onlineShoppingContext.SaveChangesAsync();
                return item;
            }
            return null;
        }
    }
}
