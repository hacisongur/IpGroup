using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class AddUniqueConstraintToIpNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "71806072-3d45-4eff-a0c5-c933a53eda25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "33ae2c79-31b0-4cf0-a23f-bc71376c0a92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93c02d3d-011c-4ef4-ac25-d21a11bbdf9d", "AQAAAAEAACcQAAAAEJQgOAR7j2UEUcFe+Z3XYSCYlLbMYekijxYpC2rpqx5GVprYB5cQXixMSHr+RaBbVA==", "e49172e3-49d3-43f1-87a0-a8193666fcda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a352b6f-d425-4133-8d54-c0bd96faf1e6", "AQAAAAEAACcQAAAAEDPytAkODdzEa5XyitZDnDm+2ug05fEo8YDYvZ1bhPCqZ4cZbrOiLb5IVnw3GHBWyQ==", "62d5913e-260a-4623-b874-39ea8effc637" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IpNo",
                table: "Categories",
                column: "IpNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_IpNo",
                table: "Categories");

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
    }
}
