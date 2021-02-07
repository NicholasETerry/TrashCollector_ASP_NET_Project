using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class neew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18805750-6b2c-45da-b81c-aeaba7343dcc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0b27418-2fd4-4be4-b264-7571fe186047");

            migrationBuilder.CreateTable(
                name: "DaysTable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef5a81e0-cd77-4493-bf3e-9d188ee9d48d", "dffc239c-6586-42a5-85b0-b4cc67bc3a46", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abf7aa96-2c10-4c81-b0df-26b3671f70e4", "5a950f1a-1273-4efa-8c0f-0c299a8e3df5", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaysTable");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abf7aa96-2c10-4c81-b0df-26b3671f70e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef5a81e0-cd77-4493-bf3e-9d188ee9d48d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0b27418-2fd4-4be4-b264-7571fe186047", "374c96c9-d607-4f60-a58a-da439d33bfd3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18805750-6b2c-45da-b81c-aeaba7343dcc", "9d621f89-df2d-4935-8393-b1d3c2f38c40", "Employee", "EMPLOYEE" });
        }
    }
}
