using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class TeacherIsFollowModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEG8i4mqnwkr+TcJltLN8wSD8Dc7awFP0Owh/moToH64g3LnuFkok6Ck22fpPclItHQ==", "9ef9d924-d257-455b-a7c0-8fa12729f8d3", "8b01ef36-9397-45cf-847f-a8ffa297f3c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEDdYgQMO6FWq4Tywrg4XiAStxnfYu9WSJbgGIPScMGcONvHl9giVo4oxmOxeGm1Yfg==", "371e26c3-8b26-404b-a7f5-c88eb1bdd75c", "487cb8b5-77e8-4989-a892-d02cbb58aeda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEBqQxxJmheNpWkTCerLQJTa4FiHZ4ToUE29RfcO2xkAshjwJX1H8+fpnN5rHGzeB3Q==", "4d35b5d3-2c9c-4c0d-8c87-e9830b613683" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
