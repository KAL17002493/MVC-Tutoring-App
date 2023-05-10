using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class booking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_StudentIdId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_TutorIdId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_StudentIdId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_TutorIdId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "StudentIdId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "TutorIdId",
                table: "Booking");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Booking",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TutorId",
                table: "Booking",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAENvCFiHt8WIcIRJ1ANeloPlCZdrQUEuFmJcjUXrQ1W+794S8TOSEwQYGXQxU30/lEA==", "531b7a8c-3fd7-4132-9d09-9161d2b90801", "bd4c176c-e11e-4b91-8e4d-ed2b7cc25d37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEACYMmmQFIfbGJ5L5z81/9A2A5BqRignlnbR1BepDtUcMQfmggRVLbjKbBO0QDD/Kw==", "48195f5c-41f2-4c95-b807-6e6bf017e31e", "f6555a75-0c6a-45f5-bb31-be8161b8e85c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEGHYpTCMuKibUc+J4Px/M673qh5fTedQ1w6ev+gPzCnaWNevoVt0J9Ed5Ul3DeoaBw==", "5bdc68a5-209f-40da-87f8-c71c290d0c24" });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_StudentId",
                table: "Booking",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TutorId",
                table: "Booking",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_StudentId",
                table: "Booking",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_TutorId",
                table: "Booking",
                column: "TutorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_StudentId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_TutorId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_StudentId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_TutorId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Booking");

            migrationBuilder.AddColumn<string>(
                name: "StudentIdId",
                table: "Booking",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TutorIdId",
                table: "Booking",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_StudentIdId",
                table: "Booking",
                column: "StudentIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_TutorIdId",
                table: "Booking",
                column: "TutorIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
