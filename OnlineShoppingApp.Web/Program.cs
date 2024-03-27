using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OnlineShoppingApp.Web;
using OnlineShoppingApp.Web.Services;
using OnlineShoppingApp.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7277/") }); //Base Adres tanýmlama(APÝ)

builder.Services.AddScoped<IProductService,ProductService>(); //Servisleri tanýmlama
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>(); //Servisleri tanýmlama

await builder.Build().RunAsync();















//Kullanýlan Api Adresleri

//1- https://localhost:7277/api/Product ürünleri listele