using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class about2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEH+MFHRHG9NooozT0kDAAIkhXtD/CP+W0Yz6yD6i+BUe3zgUu2oxoRh2FjZsQUGuZg==", "869f31f9-4426-4352-99b9-cbc8393c34e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEK6e/QimK3YGBgGlFUwyGXHMCy49ifbN5YB5d/br5K3Xx3RFpxAlGLCnSX20JyYkdQ==", "e828cff2-b49f-4625-96dc-b8a1aa94376b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEPKKnz48Ru+6g8EO0KXbwpe7881+4nVd//FetV2z8Dm+4+h6bvdl2iXYXeBKwpVBhA==", "ff27b7af-50aa-4c0b-9b48-6997e7d339d0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAENrab35KDuLx7bs08/HX1ZXHI5m4dYq/iM7TKO+ihfeePyLmAS+QNkNTtD605sR1zw==", "597b6036-ca85-483d-bb48-a21430356db7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEL3HUs+t8miY7W3uxUpRWQN4OBrNssknQcjTYwFihd241Hyxt16vB7NTD4Nmq/DI/w==", "3f3d047d-3026-4b55-b531-07a698112a72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEBM6BIbVKuEUOVK4tEscXNCE1oewyqTfe81i1qgCqycx0oj0rTPneEgAJdfYPi9Qsg==", "9bae5529-91ab-418d-b5df-dcd36972fe54" });
        }
    }
}
