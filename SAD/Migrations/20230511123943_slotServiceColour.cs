using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class slotServiceColour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardColour",
                table: "Slot",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEOj5uLiSxrMxS/49sI9abO8bahbWVnH133VKKxlJoO49FQd95U0K0Ruw8k/qdNfaqA==", "b224a03e-581e-4c86-8e2a-41c0709dd505", "589bcecf-77d1-4e3c-934c-d48622840666" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEM/Oc6xZuXK/j6dN3op781hN5qy2h5elSwmH+/ZFd/8buGq5lZ/mVheLT2GlYeMIkQ==", "345f8f62-ea10-496f-b341-657bb5315742", "ea59ff2a-1f1d-4e84-bd0d-f0646123f3db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEKpzr32UUX9TUjx1C8LgeAaikmsihR4OBwaB/zv6JsbmVwCweOu3f4b9/Qy2acE19Q==", "b2d4fc3d-c95d-49bc-a0b6-be8b681f59fc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardColour",
                table: "Slot");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAECRL208GjHUYQdRtLbKGqg5NpeWb3Tf+UDod30AUh1w3/DuFqhNrsWQYF1R0jURcKg==", "33c9a5ad-9597-4311-b540-e6e43eeaa9fd", "165db2cf-6ab4-4d5b-b4d1-352e51dd9f45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEJLg0LQqHzaVsBC/A9zVi3LAH0ChzrpLSxZgWhZCrj3pHl/cAA+GzoxRPzHLk5e2CA==", "7f1be905-2f19-435e-9653-37d008f89ecf", "7fbff3d2-b5eb-4a81-867d-56ac3adfa5f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEH70hNyoaJMHLajy57CvxN7UuT2vmdbDJIWiCflQt2aKDhfTW9Nz812b2/80gY447w==", "5e927c83-8048-48f0-9084-b005dea22792" });
        }
    }
}
