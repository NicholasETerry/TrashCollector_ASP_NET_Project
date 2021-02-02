﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class dbsetupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "457ed4a5-5174-4dfc-8f67-7749066e69d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f742922-f826-4fde-a4d9-13cb49e6db14", "31f22e12-4517-43b3-a765-492c412706c6", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f742922-f826-4fde-a4d9-13cb49e6db14");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "457ed4a5-5174-4dfc-8f67-7749066e69d9", "975c73a5-4d5f-4ef1-81a9-7ee5e9427627", "Admin", "ADMIN" });
        }
    }
}
