# ShopOnline Database Tablolar ve Seed Datalar SQL Server

﻿using Microsoft.EntityFrameworkCore;
using OnlineShoppingApp.Api.Entities;

namespace OnlineShoppingApp.Api.Data
{
    public class OnlineShoppingContext : DbContext
    {
        public OnlineShoppingContext(DbContextOptions<OnlineShoppingContext> options) : base(options)
        {
            
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            //Beauty Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Parlatıcı - Güzellik Seti",
                Description = "Glossier tarafından sağlanan, cilt bakımı, saç bakımı ve makyaj ürünlerini içeren bir kit",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 100,
                Quantity = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Curology - Cilt Bakım Seti",
                Description = "Curology tarafından sağlanan, cilt bakım ürünlerini içeren bir kit",
                ImageURL = "/Images/Beauty/Beauty2.png",
                Price = 50,
                Quantity = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Cocooil - Organik Hindistan Cevizi Yağı",
                Description = "Curology tarafından sağlanan, cilt bakım ürünlerini içeren bir kit",
                ImageURL = "/Images/Beauty/Beauty3.png",
                Price = 20,
                Quantity = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Schwarzkopf - Saç Bakım ve Cilt Bakım Seti",
                Description = "Schwarzkopf tarafından sağlanan, cilt bakımı ve saç bakım ürünlerini içeren bir kit",
                ImageURL = "/Images/Beauty/Beauty4.png",
                Price = 50,
                Quantity = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Cilt Bakım Seti",
                Description = "Cilt bakımı ve saç bakım ürünlerini içeren Cilt Bakım Seti",
                ImageURL = "/Images/Beauty/Beauty5.png",
                Price = 30,
                Quantity = 85,
                CategoryId = 1

            });
            //Electronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Airpod'lar",
                Description = "Air Pods - kulak içi kablosuz kulaklıklar",
                ImageURL = "/Images/Electronic/Electronics1.png",
                Price = 100,
                Quantity = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Kulak üstü Altın Kulaklıklar",
                Description = "Kulak üstü Altın Kulaklıklar - bu kulaklıklar kablosuz değildir",
                ImageURL = "/Images/Electronic/Electronics2.png",
                Price = 40,
                Quantity = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Kulak üstü Siyah Kulaklık",
                Description = "Kulak Üstü Siyah Kulaklıklar - bu kulaklıklar kablosuz değildir",
                ImageURL = "/Images/Electronic/Electronics3.png",
                Price = 40,
                Quantity = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Sennheiser Tripodlu Dijital Fotoğraf Makinesi",
                Description = "Sennheiser Dijital Kamera - Sennheiser tarafından sağlanan yüksek kaliteli dijital kamera - tripod içerir",
                ImageURL = "/Images/Electronic/Electronic4.png",
                Price = 600,
                Quantity = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Canon Dijital Kamera",
                Description = "Canon Dijital Kamera - Canon tarafından sağlanan yüksek kaliteli dijital kamera",
                ImageURL = "/Images/Electronic/Electronic5.png",
                Price = 500,
                Quantity = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Nintendo Gameboy'u",
                Description = "Gameboy - Nintendo tarafından sağlanmıştır",
                ImageURL = "/Images/Electronic/technology6.png",
                Price = 100,
                Quantity = 60,
                CategoryId = 3
            });
            //Furniture Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Siyah Deri Ofis Koltuğu",
                Description = "Çok rahat siyah deri ofis koltuğu",
                ImageURL = "/Images/Furniture/Furniture1.png",
                Price = 50,
                Quantity = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Pembe Deri Ofis Koltuğu",
                Description = "Çok rahat pembe deri ofis koltuğu",
                ImageURL = "/Images/Furniture/Furniture2.png",
                Price = 50,
                Quantity = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Şezlong",
                Description = "Çok rahat şezlong",
                ImageURL = "/Images/Furniture/Furniture3.png",
                Price = 70,
                Quantity = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Gümüş Şezlong",
                Description = "Çok rahat gümüş rengi şezlong",
                ImageURL = "/Images/Furniture/Furniture4.png",
                Price = 120,
                Quantity = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Porselen Masa Lambası",
                Description = "Beyaz ve mavi Porselen Masa Lambası",
                ImageURL = "/Images/Furniture/Furniture6.png",
                Price = 15,
                Quantity = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Ofis Masa Lambası",
                Description = "Ofis Masa Lambası",
                ImageURL = "/Images/Furniture/Furniture7.png",
                Price = 20,
                Quantity = 73,
                CategoryId = 2
            });
            //Shoes Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Puma Spor Ayakkabı",
                Description = "Birçok bedende konforlu Puma Spor Ayakkabı",
                ImageURL = "/Images/Shoes/Shoes1.png",
                Price = 100,
                Quantity = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Renkli Spor Ayakkabılar",
                Description = "Renkli spor ayakkabıları - çoğu boyutta mevcuttur",
                ImageURL = "/Images/Shoes/Shoes2.png",
                Price = 150,
                Quantity = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Mavi Nike Spor Ayakkabıları",
                Description = "Mavi Nike Spor Ayakkabı - Birçok bedende mevcuttur",
                ImageURL = "/Images/Shoes/Shoes3.png",
                Price = 200,
                Quantity = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Renkli Hummel Spor Ayakkabı",
                Description = "Renkli Hummel Spor Ayakkabılar - çoğu bedende mevcuttur",
                ImageURL = "/Images/Shoes/Shoes4.png",
                Price = 120,
                Quantity = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Kırmızı Nike Spor Ayakkabıları",
                Description = "Kırmızı Nike Spor Ayakkabı - çoğu bedende mevcuttur",
                ImageURL = "/Images/Shoes/Shoes5.png",
                Price = 200,
                Quantity = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Birkenstock Sandaletler",
                Description = "Birkenstock Sandaletler - çoğu boyutta mevcuttur",
                ImageURL = "/Images/Shoes/Shoes6.png",
                Price = 50,
                Quantity = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Hakan"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Zeynep"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Güzellik",
                IconCSS = "oi oi-beaker"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Mobilya",
                IconCSS = "oi oi-tablet"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Elektronik",
                IconCSS = "oi oi-calculator"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Ayakkabı",
                IconCSS = "oi oi-book"
            });
        }
    }
}
