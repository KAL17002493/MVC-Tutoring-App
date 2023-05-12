using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class SlotTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEHaWqdcdOtNGNuFRjcHQF31/eKUAr9Q7sGq4oF8EUzNPRiTXUgIDJlercpAVKmAwvg==", "785855ac-69bd-48a4-815d-3abf34aa527c", "059bcac3-c3e4-46ee-be7b-7cb28240fb9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEK1/ipAYxc6bXsn5KlbDJPoCsW7bsY7naVO8ykantqfkaDYiOK6TMLbTCNGlwnUfbg==", "fefc9ded-3982-4f95-85e2-c5ef4fcc045b", "37808cb2-59aa-424a-aa88-0baca97b079e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAECICzHQLt2Aoe6UY33cb+DggrzIx0c2E8zg146HXN4TEJQRp8kloHB3ekKvvO4RH+g==", "25be22c6-cc1f-49a3-b5e0-771df1995926" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
