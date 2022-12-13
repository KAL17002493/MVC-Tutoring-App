using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class removeType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e97d46f-5885-4d65-aa2f-29e7e2d323fd", "2a956498-1cb2-4a0f-8d27-236a95c6e820", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02", "68144efc-092a-403e-a7fe-3c276de06a72", "Tutor", "TUTOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEE8cXOnnhtkWGAg1QdrtYzSupudnUE1CW/vxXWL6bhG2U0FhryetKyXEjZ0Hr1dXfw==", "fa471558-0141-4584-8ef3-40f43423aa14" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e97d46f-5885-4d65-aa2f-29e7e2d323fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "type" },
                values: new object[] { "AQAAAAEAACcQAAAAEBqCkTWDKhIQLSFKy3TPoXIZWHwtkdjsGOpz5f0b2Fga7JAXKD4cWM2+tloC3XLO6w==", "3eb3f575-1b00-4a73-8c91-ac91d8fad822", "Admin" });
        }
    }
}
