using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class set2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "143d3180-1104-46f0-8646-62d630056f42",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEH8I4Q0CVLVE8TtQsDXu4j7BvVQvDErpgd5bycHhXwaCnyRJQDYmGbhALYqOnyDQDA==", "2310ea3b-76de-4eb5-afc2-5fdf54f0b0c1", "9f26f5a3-b028-44fe-80df-b4b18b7d118d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                columns: new[] { "PasswordHash", "SecurityStamp", "teacherCode" },
                values: new object[] { "AQAAAAEAACcQAAAAEIrmj3NPX/l+jZk+PnIViag/hvmnwWuNhccP+Xkr/+aQES6drbX0HqzO35fOMoIQmg==", "375435f5-66e3-4f1b-aecd-a45a7e0462a4", "97825f5f-5ccc-49b1-a0c7-48c9f3fa9474" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAEAACcQAAAAEBuP3qZled1k53Ua8eRWykcDIZ6qLBUAGgKIxeQynncfsbCxSmwvOKBJ8a/9FmLFBw==", "5122cb10-a0c5-4bc2-8355-03c949ca3c46" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
