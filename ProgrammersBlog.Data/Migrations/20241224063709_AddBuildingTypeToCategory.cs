using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class AddBuildingTypeToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Oda",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Categories",
                type: "int",
                maxLength: 500,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9bb6f4e8-8d2f-4c0f-936e-f812015147fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "33232694-dd44-450f-b400-8cca23171ce0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a21066e2-8a5e-4bc6-8161-133650003cc5", "AQAAAAEAACcQAAAAEJMB3uB/4+4eR85Zz1tArvMzwgyoqvVaBjLMIqTaXrkukmoDLTYG2Zt13Z0M5fq3Pw==", "75cc1064-1e2e-423b-9158-6bdb48bf74cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f6bdf03-48bb-4910-9ddf-953ed4be6d16", "AQAAAAEAACcQAAAAEGcyQ4XS8oZ4lSW6d+eQh2t7UwqBDNZP5d6NIoY2GNaXR44hAXtOLjUjX/y6DU5P5w==", "ea083ebc-7498-4dab-bcc9-1bc6c4b0e8c2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Oda",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 500);

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
    }
}
