using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class teacherModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEMSE6qP6Dhfoi2kvzV1kVUehs4ZsAUI/6Cmc+FqOCJ8RHE0UF+LRPAukBA3sde7G4Q==", "5031b0c5-1b5d-4ef8-bfe0-a13cd135caa2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb", 0, "2a956498-1cb2-4a0f-8d27-236a95c6e820", "student@student.com", false, "Student", false, null, "STUDENT@STUDENT.COM", "STUDENT@STUDENT.COM", "AQAAAAEAACcQAAAAEIIgYJDi8mXZnIaM0q+sPkLQZowAUvdLqLrqaCjyCJBuXStq25LdEmPfTCYwpKO4dA==", null, false, "Student", "3622764d-9c5a-44ee-99ad-1937ef954093", false, "student@student.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SName", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd", 0, "68144efc-092a-403e-a7fe-3c276de06a72", "tutor@tutor.com", false, "Tutor", false, null, "TUTOR@TUTOR.COM", "TUTOR@TUTOR.COM", "AQAAAAEAACcQAAAAEJZWDhGzeMhiUEy+5Xa3JG910Dl1cyUK1qiJ67hYl8eB50cfgh0X0aEvvOW6+++6BQ==", null, false, "Tutor", "e97ea359-d8f7-4e0b-90d3-0ad1d8852026", false, "tutor@tutor.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2e97d46f-5885-4d65-aa2f-29e7e2d323fd", "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02", "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e97d46f-5885-4d65-aa2f-29e7e2d323fd", "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02", "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEE8cXOnnhtkWGAg1QdrtYzSupudnUE1CW/vxXWL6bhG2U0FhryetKyXEjZ0Hr1dXfw==", "fa471558-0141-4584-8ef3-40f43423aa14" });
        }
    }
}
