using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "FoundedDate", "Leader", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Accounting" },
                    { 2, new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tim", "Sales" },
                    { 3, new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kate", "Administration" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Desciption", "Price", "ProductName", "Quantities" },
                values: new object[,]
                {
                    { 1, "", 200m, "Keyboard", 50 },
                    { 2, "", 100m, "Case", 70 },
                    { 3, "", 180m, "Mouse", 40 },
                    { 4, "", 300m, "Monitor", 20 },
                    { 5, "", 400m, "Table", 10 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "DepartmentId", "SubcriberName" },
                values: new object[,]
                {
                    { 2, 1, "John" },
                    { 4, 1, "Anna" },
                    { 1, 2, "Blake" },
                    { 3, 3, "Kate" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "OrderDate", "OrderId", "OrderPrice", "OrderQuantities", "ProductId" },
                values: new object[] { 1, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 95m, 10, 2 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "OrderDate", "OrderId", "OrderPrice", "OrderQuantities", "ProductId" },
                values: new object[] { 2, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 380m, 2, 5 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "OrderDate", "OrderId", "OrderPrice", "OrderQuantities", "ProductId" },
                values: new object[] { 3, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 160m, 5, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 3);
        }
    }
}
