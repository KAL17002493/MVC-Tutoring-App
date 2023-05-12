using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class ViewSlot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookingId",
                table: "Slot",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Slot");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEDvBfXq2MyAapz2dNDYCPzciawasIa/kCGkg/xV+aX33aJB4fc0JEyEybwrGaYKu3Q==", "3de8ff7f-79ca-4ccf-9fa4-fe252ef589d3", "4836b4eb-5d3f-4286-ad47-cf9f26433370" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEIm+EDTytsSnukbONoiJJqWz8VX6Cqo4UGPzWZgFTOtxMBXrCzaGETG0XY0BdBf+wQ==", "ea919dcd-57e4-400c-a08f-db4e1f620e34", "82d1b64d-1909-43ce-a7cd-520e326212e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEKb/qSh+8/Rcj9DXjCUnpWEKTcW/MHNK14p1GG4RsMqXYnvl1SLI00LO/4qpXBMB1g==", "3c48048c-229e-4974-bdc7-2aaab6fbb102" });
        }
    }
}
