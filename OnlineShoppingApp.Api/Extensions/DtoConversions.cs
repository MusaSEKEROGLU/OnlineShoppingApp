using OnlineShoppingApp.Api.Entities;
using OnlineShoppingApp.Models.Dtos;

namespace OnlineShoppingApp.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products,
            IEnumerable<ProductCategory> productCategories)
        {
            return (from product in products
                    join productCategory in productCategories on
                    product.CategoryId equals productCategory.Id
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        ImageURL = product.ImageURL,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        CategoryId = product.CategoryId,
                        CategoryName = productCategory.Name

                    }).ToList();
        }

        public static ProductDto ConvertToDto(this Product product,
            ProductCategory productCategory)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageURL = product.ImageURL,
                Price = product.Price,
                Quantity = product.Quantity,
                CategoryId = product.CategoryId,
                CategoryName = productCategory.Name

            };
        }

        public static IEnumerable<CartItemDto> ConvertToDto(this IEnumerable<CartItem> cartItems,
        IEnumerable<Product> products)
        {
            return (from cartItem in cartItems
                    join product in products
                    on cartItem.ProductId equals product.Id
                    select new CartItemDto
                    {
                        Id = cartItem.Id,
                        ProductId = cartItem.ProductId,
                        ProductName = product.Name,
                        ProductDescription = product.Description,
                        ProductImageURL = product.ImageURL,
                        Price = product.Price,
                        CartId = cartItem.CartId,
                        Quantity = cartItem.Quantity,
                        TotalPrice = product.Price * cartItem.Quantity

                    }).ToList();
        }

        public static CartItemDto ConvertToDto(this CartItem cartItem,
        Product product)
        {
            return new CartItemDto
            {
                Id = cartItem.Id,
                ProductId = cartItem.ProductId,
                ProductName = product.Name,
                ProductDescription = product.Description,
                ProductImageURL = product.ImageURL,
                Price = product.Price,
                CartId = cartItem.CartId,
                Quantity = cartItem.Quantity,
                TotalPrice = product.Price * cartItem.Quantity

            };
        }
    }
}

//YAPILMAK İSTENEN
//Bu C# kodu, `DtoConversions` adlı bir statik sınıf içerisinde bulunan
//`ConvertToDto` adlı bir genişletme yöntemi (extension method) içerir. Bu yöntemin amacı, 
//    `IEnumerable<Product>` ve `IEnumerable<ProductCategory>`
//    koleksiyonlarını alarak `ProductDto` türündeki bir koleksiyona dönüştürmektedir.

//İşlem şu adımları izler:

//1. `products` ve `productCategories` koleksiyonlarını birleştirme işlemi yapılır.
//Bu işlem, `Product` nesnelerinin `CategoryId` özelliği ile `ProductCategory` nesnelerinin `Id` özelliği arasında eşleşme yaparak gerçekleştirilir.
//2. Birleştirme işlemi sonucunda her eşleşme için yeni bir `ProductDto` nesnesi oluşturulur.
//Bu nesne, `Product` ve `ProductCategory` nesnelerinin özelliklerini kullanarak doldurulur.
//3. Oluşturulan `ProductDto` nesneleri bir liste halinde dönüştürülerek döndürülür.

//Özet, bu işlem `Product` ve `ProductCategory` nesnelerini alır, bu nesneleri birleştirir ve `ProductDto` nesnelerine dönüştürerek yeni bir koleksiyon oluşturur.
//Bu koleksiyon daha sonra döndürülerek kullanıcıya sunulur.