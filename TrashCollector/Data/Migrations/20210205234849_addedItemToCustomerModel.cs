using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addedItemToCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0798242a-74f5-4abd-8b48-337a6a550040");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b17f6816-2c13-489c-9b57-c6b4a1e0df7b");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "EmployeesTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CustomersTable",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ca26746-2cf6-4873-a707-6176cdac7806", "cc871da8-9957-4b55-92ea-f06e8884d25f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fe8e038-9934-40dc-a892-89f90c5fc2c5", "2155d70d-707f-4bea-9e64-3640fcfa2490", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesTable_IdentityUserId",
                table: "EmployeesTable",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesTable_AspNetUsers_IdentityUserId",
                table: "EmployeesTable",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesTable_AspNetUsers_IdentityUserId",
                table: "EmployeesTable");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesTable_IdentityUserId",
                table: "EmployeesTable");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fe8e038-9934-40dc-a892-89f90c5fc2c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ca26746-2cf6-4873-a707-6176cdac7806");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "EmployeesTable");

            migrationBuilder.DropColumn(
                name: "City",
                table: "CustomersTable");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0798242a-74f5-4abd-8b48-337a6a550040", "89774ea0-ee49-4f73-b1e5-4158a6c8083d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b17f6816-2c13-489c-9b57-c6b4a1e0df7b", "7a0f3330-102f-4912-acac-8cf6f7a09e68", "Employee", "EMPLOYEE" });
        }
    }
}
