using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopsRUs.Repository.Migrations
{
    public partial class tri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InvoiceTypes",
                columns: new[] { "Id", "CreateDate", "type" },
                values: new object[] { 1, new DateTime(2022, 4, 2, 23, 36, 52, 937, DateTimeKind.Local).AddTicks(7385), "Groceries" });

            migrationBuilder.InsertData(
                table: "InvoiceTypes",
                columns: new[] { "Id", "CreateDate", "type" },
                values: new object[] { 2, new DateTime(2022, 4, 2, 23, 36, 52, 937, DateTimeKind.Local).AddTicks(7395), "Textile" });

            migrationBuilder.InsertData(
                table: "InvoiceTypes",
                columns: new[] { "Id", "CreateDate", "type" },
                values: new object[] { 3, new DateTime(2022, 4, 2, 23, 36, 52, 937, DateTimeKind.Local).AddTicks(7396), "Stationary" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InvoiceTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InvoiceTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InvoiceTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
