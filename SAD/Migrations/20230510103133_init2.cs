using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TutorIdId = table.Column<string>(type: "TEXT", nullable: true),
                    StudentIdId = table.Column<string>(type: "TEXT", nullable: true),
                    TimeSlot = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_AspNetUsers_StudentIdId",
                        column: x => x.StudentIdId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Booking_AspNetUsers_TutorIdId",
                        column: x => x.TutorIdId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEF/AHaZC4sw1w7hCNHvoAaxpCNGXRWe2fzMezCK9fn0lKWIE70x4XcCfp1lI3gzzMA==", "4a88c09b-acda-492b-bb3b-d60a90bbe2c3", "60545cf6-826b-43a0-b3ee-b37a1c950b50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEB7uQKpgbjGgoozihy/eKdJb5tZFHZH2IuA8qhturwltnwEmTLHiUP7J6+7FtgVO6Q==", "873cec68-af88-4645-85bf-32274bc4a688", "04defc0b-29b5-4b6a-a294-1bc5523568bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEL9gqjT6tqz9R9kPz1iAzo+R0ucU5VDONG+ZNr176v0XZGJ2NgL552JeUBp2HMfh3Q==", "367e1618-f6c4-4b76-92fc-f0f4aef64fff" });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_StudentIdId",
                table: "Booking",
                column: "StudentIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TutorIdId",
                table: "Booking",
                column: "TutorIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

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
    }
}
