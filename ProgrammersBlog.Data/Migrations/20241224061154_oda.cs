using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class oda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Oda",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "db32864b-5c90-4391-bef4-275f70e59e80");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "159d331e-cfcd-482a-9fb2-e2c9b4a1f8ba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42b4910b-071a-4766-bcb8-9949501cea9e", "AQAAAAEAACcQAAAAEElPxMRCFu80OGpu6rCXLJagI9Td0sII2aW7GWZlupD/UDwW4P9ez5JEopL+hxCadw==", "d5a5829a-f949-4e38-b440-96de2f5715f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dacb3df-7df3-48ba-8a45-053a5587ee32", "AQAAAAEAACcQAAAAEBaSiblMTJ30LewCXfaD2mX2j/uFjU2dUiawaXUInGIXQTX2fQRa8lZ0utwxIAtpEg==", "41f34f26-85e2-41c4-a72f-0e5ade8d6bca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oda",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0e7668c0-f95a-4d44-abf7-1e2df6cd7167");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "12bd38b3-50aa-40e2-8b6f-9fcde5019b02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffa0040a-0c27-4b5c-874d-57f459bdfb3e", "AQAAAAEAACcQAAAAECqkjyBT3lxM3OGlFa3mVa9n4lbxMcvkGiZRPblzusjn4RBRuMmKl9FcibiD/QCc9g==", "c9229a9e-5907-45ee-82ee-d6ea6aa292f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71e9eb80-78bd-46d6-afde-bdab10cb25b5", "AQAAAAEAACcQAAAAENWmAgqXksnfY9UwN51c85bSRV9N7lxTeJoKWbZ773HYRx9E0lolq8etGtItLhXOCQ==", "e3702c08-a49c-41fa-9aa9-ed889adf2b16" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Bina", "CreatedByName", "CreatedDate", "Description", "IpNo", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name", "Note", "PcAdi" },
                values: new object[] { 1, "Blok A", "Migration", new DateTime(2024, 12, 23, 15, 32, 57, 970, DateTimeKind.Local).AddTicks(5630), "Python Programlama Dili ile İlgili En Güncel Bilgiler", "192.168.1.1", true, false, "Migration", new DateTime(2024, 12, 23, 15, 32, 57, 970, DateTimeKind.Local).AddTicks(5863), "Python", null, "Server1" });
        }
    }
}
