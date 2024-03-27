using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using OnlineShoppingApp.Api.Data;
using OnlineShoppingApp.Api.Repositories;
using OnlineShoppingApp.Api.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

//DB adresi Tanýmlama appsettings.json
builder.Services.AddDbContextPool<OnlineShoppingContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShoppingConnection"));
});

//Repository ve Servisleri tanýmlama
builder.Services.AddScoped<IProductRepository,ProductRepository>();  
builder.Services.AddScoped<IShoppingCartRepository,ShoppingCartRepository>();  


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Api Cors Ayarlarý
app.UseCors(policy => policy.WithOrigins("http://localhost:7052", "https://localhost:7052") //Web.UI Adresleri(apiye istek yapan adresler)
.AllowAnyMethod()
.WithHeaders(HeaderNames.ContentType));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
