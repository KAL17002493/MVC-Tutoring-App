using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class addToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Slot",
                columns: table => new
                {
                    SlotId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    SlotTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slot", x => x.SlotId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slot");

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
    }
}
