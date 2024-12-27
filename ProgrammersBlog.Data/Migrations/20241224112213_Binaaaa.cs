using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class Binaaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bina",
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
                value: "d942b1d9-bc72-4b0b-858b-eda65a70ac12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "6469132b-bb86-4ad5-9d1d-15ad8dd0f31d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d774480-8bb3-4e49-9ae5-75c3c711654b", "AQAAAAEAACcQAAAAEM7Wv/kgsxLGIMgG3ahYHL/oqEArp1kiwDLK6tUkChB9u3ZMZItfzIdXCqm9OOorhg==", "e03f1ecc-7a38-4b29-b121-4aa7bf3bcf23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f17fa75c-9177-441c-8495-8c3baccf5665", "AQAAAAEAACcQAAAAEDGjXEdkxkT+9paAv9rhPaSzi1Kfw2uwtcwIi5YUjUvTegYavFbMcjJzx6jYrUwZoQ==", "87f7c923-ab72-40f1-b790-fc2bb8a91c5a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Bina",
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
    }
}
