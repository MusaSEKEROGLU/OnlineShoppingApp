using Microsoft.AspNetCore.Components;
using OnlineShoppingApp.Models.Dtos;

namespace OnlineShoppingApp.Web.Pages
{
    public class DisplayProductBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
