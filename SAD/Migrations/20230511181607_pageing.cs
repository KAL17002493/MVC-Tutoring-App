using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAD.Migrations
{
    public partial class pageing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
