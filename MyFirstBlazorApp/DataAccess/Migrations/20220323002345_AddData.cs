using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "CTH", "Clothes" },
                    { "HCN", "Home Cleaning" },
                    { "HTH", "Health" },
                    { "KTN", "Kitchen" },
                    { "PNC", "Personal Care" },
                    { "TYS", "Toys" },
                    { "VDG", "Video Games" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "8d248e68-496c-4693-9525-626dd0a9997a", "New York City, New York", "New York Warehouse" },
                    { "c2cdf383-3a9d-4e3e-8a8e-8dbd6bca717b", "Idaho Falls, Idaho ", "Idaho Warehouse" },
                    { "d9c10f08-72c4-4e78-b445-0907982bc079", "Missouri, Kansas", "Kansas Warehouse" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "CTH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HCN");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HTH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "KTN");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PNC");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "TYS");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VDG");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "8d248e68-496c-4693-9525-626dd0a9997a");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "c2cdf383-3a9d-4e3e-8a8e-8dbd6bca717b");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d9c10f08-72c4-4e78-b445-0907982bc079");
        }
    }
}
