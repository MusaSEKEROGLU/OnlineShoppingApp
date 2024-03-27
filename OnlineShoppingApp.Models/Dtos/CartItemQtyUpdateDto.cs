using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingApp.Models.Dtos
{
    public class CartItemQtyUpdateDto
    {
        public int CartItemId { get; set; }
        public int Quantity { get; set; }
    }
}
