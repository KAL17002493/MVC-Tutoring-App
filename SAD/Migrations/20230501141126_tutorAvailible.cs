using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class tutorAvailible : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TutorAvailabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TutorId = table.Column<string>(type: "TEXT", nullable: false),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    End = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorAvailabilities", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAECVuPtY1amXs2eOpij2AFgC5L2f9GmhLyYgJdrSBrbD70RMyyH5r7uf2i3YIkZRDVw==", "b22c248a-331a-4d18-a2b2-151461336514", "801f1d40-730a-4326-b2d1-aed4afd6b926" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEBQ4kpSHpSwUdlX8Q7TShQKJglSgXZK6Kn8hWff4zpyuwPY6Awr7MoUciPox/fo1ew==", "8154a5f0-1072-495f-8662-e0fc304301b0", "0474c35b-b9ba-4bd4-91a9-fbc86c05f846" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEHDfJ+rg5YoE2G83JJQUeQ41OLJN9XRIJmi1oiQ6rJ+5LDRb3hRcEKx6cXq1tJkh3g==", "61a8b2be-e7d8-4154-9762-a804d6748fd6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TutorAvailabilities");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEDGaU6kBK79Z2n2NUFVEaUiLnRzXBn0U/WoaMBY+K9b60OoDYu9+wpa0OLSzEdVMBg==", "5e099471-7b76-4037-a284-bf99722352e0", "7c087e65-acf3-4f8b-9756-c8e6832b8c6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEJ9mN0e11VVQfLl7SsrKEqnyt/vOvqzgcouFBzdHwZ3r0iDVGdejkWRErXUhgWJgQQ==", "4efc2614-d416-4f89-99d3-d4ba8bd24a10", "da462942-e80e-45a4-807d-c95c438db001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEC8NGWoPEEeTOasVanr5uK2u1F0lS0mDW4T9c4Z8oTsrljIkzsxq3baBvsM0TwlHYA==", "a2f9641d-3709-4812-9ab5-f046af4d9256" });
        }
    }
}
