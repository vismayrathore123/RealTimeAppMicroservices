using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.API.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "Camera" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, 1, "𝗖𝗿𝘆𝘀𝘁𝗮𝗹 𝗖𝗹𝗲𝗮𝗿 𝗔𝘂𝗱𝗶𝗼 𝘄𝗶𝘁𝗵 𝗦𝗺𝗮𝗿𝘁𝗹𝗶𝗻𝗸 𝗖𝗵𝗶𝗽: Enjoy pristine audio quality with built-in Smartlink technology that intelligently filters noise for enhanced clarity.𝗣𝗹𝘂𝗴 & 𝗣𝗹𝗮𝘆 𝗔𝘂𝘁𝗼𝗺𝗮𝘁𝗶𝗰 𝗣𝗮𝗶𝗿𝗶𝗻𝗴: Hassle-free setup with automatic pairing for quick and easy use.𝗛𝗶𝗴𝗵 𝗣𝗲𝗿𝗳𝗼𝗿𝗺𝗮𝗻𝗰𝗲 𝗪𝗶𝗿𝗲𝗹𝗲𝘀𝘀 𝗧𝗿𝗮𝗻𝘀𝗺𝗶𝘀𝘀𝗶𝗼𝗻: Experience seamless wireless transmission with high-performance 2.4G technology. 𝗧𝘆𝗽𝗲 𝗖 𝗙𝗮𝘀𝘁 𝗖𝗵𝗮𝗿𝗴𝗲: Convenient Type C charging ensures fast and efficient power replenishment.", "https://containermicroserviceapp.blob.core.windows.net/productimages/2.webp", 4399m, "Digitek® (DWM 101 Wireless Microphone System with ANC Noise Reduction, 360° Sound Capture, 100M Range, Upto 12 Hrs Working Time, for DSLR Camera, Android & iOS Smartphones, Seamless Audio Recording" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, 1, "𝗦𝗧𝗨𝗥𝗗𝗬 𝗖𝗢𝗡𝗦𝗧𝗥𝗨𝗖𝗧𝗜𝗢𝗡: Crafted by Digitek, the DTR 550 LW features durable aluminum alloy legs for stability and reliability.𝗔𝗗𝗝𝗨𝗦𝗧𝗔𝗕𝗟𝗘 𝗛𝗘𝗜𝗚𝗛𝗧: With a maximum height of 67 inches and foldable design, achieve the perfect shot from various angles.𝗩𝗘𝗥𝗦𝗔𝗧𝗜𝗟𝗘 𝗖𝗢𝗠𝗣𝗔𝗧𝗜𝗕𝗜𝗟𝗜𝗧𝗬: Compatible with digital cameras, video cameras, DSLRs, projectors, and smartphones, offering adaptability for diverse shooting needs.𝗦𝗘𝗖𝗨𝗥𝗘 𝗟𝗢𝗔𝗗 𝗖𝗔𝗣𝗔𝗖𝗜𝗧𝗬: Supports a maximum load of 5kg, ensuring your equipment stays safe and steady during use.", "https://containermicroserviceapp.blob.core.windows.net/productimages/3.jpg", 4399m, "DIGITEK® (DTR 550 LW) 67 Inch Foldable Tripod Stand with Phone Holder & 360° Ball Head, 5kg Load Capacity, Aluminum Alloy Legs with Rubberized Feet & Flip Locks, Carry Bag, for Photo & Video Shoots" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, 1, "【4K & 64MP Cameras for Photography】📷：Explore a variety of video resolution options such as 4K, 2.7K, 1080P, and 720P, along with high-resolution photo options including 64MP, 56MP, 48MP, and 24MP with the Saneen camera. This camera is the perfect choice for beginners and hobbyists. Elevate your content creation with this innovative photography cameras with user-friendly design.", "https://containermicroserviceapp.blob.core.windows.net/productimages/4.jpg", 27073m, "Saneen Digital Camera for Photography, 4K 64MP WiFi Touch Screen Vlogging Camera with Flash, 32GB SD Card, Lens Hood, 3000mAH Battery, Front and Rear Cameras, 4″Big Screen, Hot Shoe Interface - Black" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
