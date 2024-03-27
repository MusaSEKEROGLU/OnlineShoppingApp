using Microsoft.AspNetCore.Components;
using OnlineShoppingApp.Models.Dtos;
using OnlineShoppingApp.Web.Services.Contracts;
using System.Linq;

namespace OnlineShoppingApp.Web.Pages
{
    public class ProductBase : ComponentBase
    {
        //Asp.Net Core Razor Component lifecycle

        [Inject]
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }

        //Products.razor
        protected IOrderedEnumerable<IGrouping<int,ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
                   group product by product.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }

        //Products.razor
        protected string GetCategoryName(IGrouping<int,ProductDto> groupedProductDtos) 
        {
            return groupedProductDtos.FirstOrDefault(pg => pg.CategoryId == groupedProductDtos.Key).CategoryName;
        }
    }
}
