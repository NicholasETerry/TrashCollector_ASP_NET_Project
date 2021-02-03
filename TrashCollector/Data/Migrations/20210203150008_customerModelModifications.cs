using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class customerModelModifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24236bb8-b845-486d-a0f8-3ac4cb574fbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3eb2c016-9190-4e5b-894e-0b7a808eb421");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "961ff02b-c4b0-4610-8043-5b2870a185a3");

            migrationBuilder.AddColumn<DateTime>(
                name: "TempSuspendEnd",
                table: "CustomersTable",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TempSuspendStart",
                table: "CustomersTable",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0798242a-74f5-4abd-8b48-337a6a550040", "89774ea0-ee49-4f73-b1e5-4158a6c8083d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b17f6816-2c13-489c-9b57-c6b4a1e0df7b", "7a0f3330-102f-4912-acac-8cf6f7a09e68", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0798242a-74f5-4abd-8b48-337a6a550040");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b17f6816-2c13-489c-9b57-c6b4a1e0df7b");

            migrationBuilder.DropColumn(
                name: "TempSuspendEnd",
                table: "CustomersTable");

            migrationBuilder.DropColumn(
                name: "TempSuspendStart",
                table: "CustomersTable");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3eb2c016-9190-4e5b-894e-0b7a808eb421", "e41dd317-9a5f-462d-8f53-d942ff2c0814", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24236bb8-b845-486d-a0f8-3ac4cb574fbc", "8c6c9906-8394-469a-84e7-3c24109aa77c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "961ff02b-c4b0-4610-8043-5b2870a185a3", "4e0ddfa1-b0f5-4cea-bcb2-cb333ea00c3c", "Employee", "EMPLOYEE" });
        }
    }
}
