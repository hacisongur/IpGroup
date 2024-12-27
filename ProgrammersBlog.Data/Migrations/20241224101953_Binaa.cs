using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class Binaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "Bina",
                table: "Categories",
                type: "int",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d6e39b84-884f-43ee-a92f-c2e49ced33fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3abfbfdc-8ccf-4f16-85f0-1be95a756663");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdb9f56d-a272-4bd6-bd33-f797c07acc03", "AQAAAAEAACcQAAAAEBHKoeHJVGrcxzR1BSW6luVrOGIzlbbrX7bpjpDyMIkrc7Y8fXHqfbFRsc9pfNQ6Aw==", "9fc25b4a-4b0d-4c70-9fe3-141c27f92f2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d963e569-4cce-406b-9e70-92f91bfa7633", "AQAAAAEAACcQAAAAEMwXEAQ5TFycke4r6c9GEmHw4qeSneHtVrNVpNFjDH+/9FSUyXzVnXAPkMst6cWMqw==", "497ca41e-30f2-4c23-b826-83bed66b10ef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Bina",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 500);

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
    }
}
