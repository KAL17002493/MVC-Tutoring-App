using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class subjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSubject",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsTeachable = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubject", x => new { x.UserId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_UserSubject_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEIbU946PJQI+K2cKYN6u0yWehcd2dW8br2JXFvWHlzhHq/JVtArCIF0RW65L4EqyGQ==", "13eebb7a-9e00-4d67-b160-a019fbdbe06f", "24055348-2b29-421d-aca3-d183a07feb93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEBIvKza0nnBMzDoSL1+DqhyK0HsIpLDuMdbRin+8t+fxmA1kAOEI49971r5kPzOBfA==", "45b32b06-098d-446f-9110-fa6ef8eb913d", "c8be3112-1b2d-4b68-96a2-e8cde2adb92f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAENtCdte3h7DvA4H1/5U2XsyG87oN+423XV45d47SD+ym7vCtF4jAAUQJpwlphHOJyg==", "8e048036-2aab-4fbc-a02a-f39fd6a0b3e1" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Mathematics" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Physics" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Chemistry" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Biology" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "English Literature" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "History" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Geography" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Computer Science" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Spanish" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "French" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "German" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "Art" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "Music" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "Physical Education" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 15, "Psychology" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 16, "Sociology" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 17, "Economics" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 18, "Business Studies" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 19, "Accounting" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 20, "Chemical Engineering" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 21, "Civil Engineering" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 22, "Electrical Engineering" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 23, "Mechanical Engineering" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 24, "Astronomy" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 25, "Environmental Science" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 26, "Political Science" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 27, "Law" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 28, "Philosophy" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 29, "Anthropology" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 30, "Archaeology" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 31, "Religious Studies" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 32, "Film Studies" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 33, "Media Studies" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 34, "Graphic Design" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 35, "Web Development" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 36, "Mobile App Development" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 37, "Data Science" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 38, "Machine Learning" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 39, "Artificial Intelligence" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 40, "Robotics" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 41, "Marketing" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 42, "Advertising" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 43, "Finance" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 44, "Statistics" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 45, "Mathematical Statistics" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 46, "Actuarial Science" });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name" },
                values: new object[] { 47, "Literary Studies" });

            migrationBuilder.CreateIndex(
                name: "IX_UserSubject_SubjectId",
                table: "UserSubject",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSubject");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEMccaUrQDEDwvrbJ6WsRIgGEgc+V3186qolJNuGOHlZ1Gx5HY6tHtNn/LUhNfwY7OA==", "452edc42-3e11-42fe-8f9f-2e1c63419a33", "597138b4-4ebe-40ca-94c1-f61a8cca3036" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEEjiXcOG2u3cM9htAiiTWxupkCqLy7WALwoyKB2fVXwm35lKrM19TzKXl6sbZVXgVg==", "bd571220-7f90-4d88-87eb-d95c5d003ad3", "9d9faa94-39d1-4f65-815d-1b61a0b0cd1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEDLDzl8YDF8/rKe320jzMj4OgYhogwqR+wDQHKefpgWcwEt6xl1wEBa5L83Uq8BFTw==", "9a0094f4-dc7d-45e8-8575-2a41cb2a45f0" });
        }
    }
}
