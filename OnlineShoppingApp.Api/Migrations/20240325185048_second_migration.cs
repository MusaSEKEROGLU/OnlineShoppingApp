using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShoppingApp.Api.Migrations
{
    public partial class second_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Güzellik");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Mobilya");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Elektronik");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Ayakkabı");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Glossier tarafından sağlanan, cilt bakımı, saç bakımı ve makyaj ürünlerini içeren bir kit", "Parlatıcı - Güzellik Seti" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curology tarafından sağlanan, cilt bakım ürünlerini içeren bir kit", "Curology - Cilt Bakım Seti" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curology tarafından sağlanan, cilt bakım ürünlerini içeren bir kit", "Cocooil - Organik Hindistan Cevizi Yağı" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Schwarzkopf tarafından sağlanan, cilt bakımı ve saç bakım ürünlerini içeren bir kit", "Schwarzkopf - Saç Bakım ve Cilt Bakım Seti" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Cilt bakımı ve saç bakım ürünlerini içeren Cilt Bakım Seti", "Cilt Bakım Seti" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Air Pods - kulak içi kablosuz kulaklıklar", "Airpod'lar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kulak üstü Altın Kulaklıklar - bu kulaklıklar kablosuz değildir", "Kulak üstü Altın Kulaklıklar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kulak Üstü Siyah Kulaklıklar - bu kulaklıklar kablosuz değildir", "Kulak üstü Siyah Kulaklık" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sennheiser Dijital Kamera - Sennheiser tarafından sağlanan yüksek kaliteli dijital kamera - tripod içerir", "Sennheiser Tripodlu Dijital Fotoğraf Makinesi" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Canon Dijital Kamera - Canon tarafından sağlanan yüksek kaliteli dijital kamera", "Canon Dijital Kamera" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Gameboy - Nintendo tarafından sağlanmıştır", "Nintendo Gameboy'u" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Çok rahat siyah deri ofis koltuğu", "Siyah Deri Ofis Koltuğu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Çok rahat pembe deri ofis koltuğu", "Pembe Deri Ofis Koltuğu" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Çok rahat şezlong", "Şezlong" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Çok rahat gümüş rengi şezlong", "Gümüş Şezlong" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Beyaz ve mavi Porselen Masa Lambası", "Porselen Masa Lambası" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ofis Masa Lambası", "Ofis Masa Lambası" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Birçok bedende konforlu Puma Spor Ayakkabı", "Puma Spor Ayakkabı" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Renkli spor ayakkabıları - çoğu boyutta mevcuttur", "Renkli Spor Ayakkabılar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Mavi Nike Spor Ayakkabı - Birçok bedende mevcuttur", "Mavi Nike Spor Ayakkabıları" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Renkli Hummel Spor Ayakkabılar - çoğu bedende mevcuttur", "Renkli Hummel Spor Ayakkabı" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kırmızı Nike Spor Ayakkabı - çoğu bedende mevcuttur", "Kırmızı Nike Spor Ayakkabıları" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Birkenstock Sandaletler - çoğu boyutta mevcuttur", "Birkenstock Sandaletler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserName",
                value: "Hakan");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserName",
                value: "Zeynep");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Beauty");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Furniture");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Electronics");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Shoes");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A kit provided by Glossier, containing skin care, hair care and makeup products", "Glossier - Beauty Kit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "Curology - Skin Care Kit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A kit provided by Curology, containing skin care products", "Cocooil - Organic Coconut Oil" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A kit provided by Schwarzkopf, containing skin care and hair care products", "Schwarzkopf - Hair Care and Skin Care Kit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Skin Care Kit, containing skin care and hair care products", "Skin Care Kit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Air Pods - in-ear wireless headphones", "Air Pods" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "On-ear Golden Headphones - these headphones are not wireless", "On-ear Golden Headphones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "On-ear Black Headphones - these headphones are not wireless", "On-ear Black Headphones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "Sennheiser Digital Camera with Tripod" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Canon Digital Camera - High quality digital camera provided by Canon", "Canon Digital Camera" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Gameboy - Provided by Nintendo", "Nintendo Gameboy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable black leather office chair", "Black Leather Office Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable pink leather office chair", "Pink Leather Office Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable lounge chair", "Lounge Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable Silver lounge chair", "Silver Lounge Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name" },
                values: new object[] { "White and blue Porcelain Table Lamp", "Porcelain Table Lamp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Office Table Lamp", "Office Table Lamp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Comfortable Puma Sneakers in most sizes", "Puma Sneakers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Colorful trainsers - available in most sizes", "Colorful Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Blue Nike Trainers - available in most sizes", "Blue Nike Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Colorful Hummel Trainers - available in most sizes", "Colorful Hummel Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Red Nike Trainers - available in most sizes", "Red Nike Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Birkenstock Sandles - available in most sizes", "Birkenstock Sandles" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserName",
                value: "Bob");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserName",
                value: "Sarah");
        }
    }
}
