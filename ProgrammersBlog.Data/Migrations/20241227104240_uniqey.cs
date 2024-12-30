using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammersBlog.Data.Migrations
{
    public partial class uniqey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_IpNo",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ddf69390-bb5c-4c2e-951c-6142e8bcff19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "894ec9f9-449e-4052-88ba-d6206dab758f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8204b487-b28d-407d-89c1-5c6117745506", "AQAAAAEAACcQAAAAEJPTSxFPB8CbxzT717lNMCAjjjBekgI2H/w1aCUjrScjFsp2CaqBWOlbppA/5sZ9Qg==", "3a99f9c4-b404-45f7-95e0-2ef933dc6870" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "309de3fb-582d-4399-9407-ec96ecec7055", "AQAAAAEAACcQAAAAENXBAiSbYpFQhfw+L1MNoV7OHnf/Vbg7QrWzh0Tg6KhHVCRfjuoH+10mVyaRc1jozg==", "04d5cedc-286c-4c29-8e83-fbd73df08f4d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
