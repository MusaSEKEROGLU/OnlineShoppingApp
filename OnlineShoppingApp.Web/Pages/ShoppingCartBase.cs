using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using OnlineShoppingApp.Models.Dtos;
using OnlineShoppingApp.Web.Services.Contracts;

namespace OnlineShoppingApp.Web.Pages
{
    public class ShoppingCartBase : ComponentBase
    {
        [Inject]
        public IJSRuntime Js { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }
        public List<CartItemDto> ShoppingCartItems { get; set; }
        public string ErrorMessage { get; set; }
        protected string TotalPrice { get; set; }
        protected int TotalQuantity { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ShoppingCartService.GetItems(DenemeCod.UserId);
                CalculateCartSummaryTotals();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
        protected async Task DeleteCartItem_Click(int id)
        {
            var cartItemDto = await ShoppingCartService.DeleteItem(id);
            RemoveCartItem(id);
            CalculateCartSummaryTotals();
        }
        protected async Task UpdateQtyCartItem_Click(int id, int qty)
        {
            try
            {
                if (qty > 0)
                {
                    var updateItemDto = new CartItemQtyUpdateDto
                    {
                        CartItemId = id,
                        Quantity = qty
                    };

                    var returnedUpdateItemDto = await ShoppingCartService.UpdateQty(updateItemDto);

                    UpdateItemTotalPrice(returnedUpdateItemDto);

                    CalculateCartSummaryTotals();

                    await Js.InvokeVoidAsync("MakeUpdateQtyButtonVisible", id, false);

                }
                else
                {
                    var item = ShoppingCartItems.FirstOrDefault(i => i.Id == id);
                    if (item != null)
                    {
                        item.Quantity = qty;
                        item.TotalPrice = item.Price;

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected async Task UpdateQty_Input(int id)
        {
            //ShoppingCartFunction.js dosyasında
            await Js.InvokeVoidAsync("MakeUpdateQtyButtonVisible", id, true);
        }
        private void UpdateItemTotalPrice(CartItemDto cartItemDto)
        {
            var item = GetCartItem(cartItemDto.Id);

            if (item != null)
            {
                item.TotalPrice = cartItemDto.Price * cartItemDto.Quantity;
            }
        }
        private void CalculateCartSummaryTotals()
        {
            SetTotalPrice();
            SetTotalQuantity();
        }
        private void SetTotalPrice()
        {
            TotalPrice = ShoppingCartItems.Sum(p => p.TotalPrice).ToString("C");
        }
        private void SetTotalQuantity()
        {
            TotalQuantity = ShoppingCartItems.Sum(p => p.Quantity);
        }
        private CartItemDto GetCartItem(int id)
        {
            return ShoppingCartItems.FirstOrDefault(i => i.Id == id);
        }
     
        private void RemoveCartItem(int id)
        {
            var cartItemDto = GetCartItem(id);
            ShoppingCartItems.Remove(cartItemDto);
        }
    }
}
