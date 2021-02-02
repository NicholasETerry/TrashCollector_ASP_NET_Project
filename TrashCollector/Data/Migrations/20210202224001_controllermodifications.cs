using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class controllermodifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53806fef-50ca-4420-a575-d605bcd41c18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bf10a3e-73dc-4f78-99a6-4ea7bd3d7171");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d536684f-3843-4e5b-9d5c-e0c444751115");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bf10a3e-73dc-4f78-99a6-4ea7bd3d7171", "fc4a74fd-b4f4-46c8-a6ec-9b710e964601", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53806fef-50ca-4420-a575-d605bcd41c18", "4cecb6f4-3483-4e7c-87f1-7628fc9003f7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d536684f-3843-4e5b-9d5c-e0c444751115", "57e4f297-3a0e-4b46-872b-b1b5c366333b", "Employee", "EMPLOYEE" });
        }
    }
}
