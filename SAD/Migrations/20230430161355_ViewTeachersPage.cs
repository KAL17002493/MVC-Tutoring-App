using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class ViewTeachersPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEGPmm1iuI8de9+3DOCVEJMYDCj1ZXwOrlK05jI+pytqlIeByRTQtvJxwS7myFw2bew==", "ddb49fb3-067d-4358-b9c1-0b4d4ddaafa1", "fd4c6657-39e9-4842-96af-0a63c60f6147" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAECqU8t2oKg/gJZ/8Lv6Ufv4n+dZgHivSQbf26qVJQhu4ZQZZCJpHvHoQxst9oQTf2w==", "9c7146fa-3278-4bee-a61e-b383c488d87e", "12b93496-0d4f-467c-929d-dc948fc5dbd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEEnDZu6T61FbypGr5npMtbXaoC2woIlQyNkN6GeQrNYuBFDyYZrvIYk/Qs6YGan5vA==", "54d42d31-3c4f-4601-a476-bd6c74c686c6" });
        }
    }
}
