using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class builderEniyAddedDataSes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e48efe60-bbbc-4799-88be-609fab8954a5");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "CustomersTable",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_CustomersTable_IdentityUserId",
                table: "CustomersTable",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersTable_AspNetUsers_IdentityUserId",
                table: "CustomersTable",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersTable_AspNetUsers_IdentityUserId",
                table: "CustomersTable");

            migrationBuilder.DropIndex(
                name: "IX_CustomersTable_IdentityUserId",
                table: "CustomersTable");

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

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "CustomersTable");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e48efe60-bbbc-4799-88be-609fab8954a5", "35eea2c6-0a83-4999-9ad2-17c55f910a77", "Admin", "ADMIN" });
        }
    }
}
