using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementApp.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35c786b6-f6a1-4b28-9b58-8e1b7c479a57",
                column: "ConcurrencyStamp",
                value: "4f0632f8-00cc-4208-a47f-c13624a21c8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45c576b6-f6a1-4b28-9b58-8e1b7c479b57",
                column: "ConcurrencyStamp",
                value: "8b6fbe8a-bad0-419d-8749-505ad15536b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c280b6-f6a1-4b66-9b56-8e1b7a479a57",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "437429cf-7c17-4300-bff2-e82e53c53766", true, "ADMIN@YOPMAIL.COM", "AQAAAAEAACcQAAAAEKYYQvBpnpJ4jJDYK1UlrhVloB1ma0BmgKiTZ6luYvP35f0FTxV6ICIw7X1/g8GgGA==", "6a573f44-e7cf-49c1-a862-ad9ab0cbc00a", "admin@yopmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c290b6-f6a1-4b66-9d56-8e1b7a333a57",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "27a75991-1677-41be-a01b-08a24d40f030", true, "USER@YOPMAIL.COM", "AQAAAAEAACcQAAAAEJOF1SsNhTKmGF62rqKoD0iYgwvgz6PEJ14dtBHR6MGg3LIPWiF6Y8RisQcaWOgukg==", "8e6976f8-7ee0-4e01-9031-c96a18ced351", "user@yopmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35c786b6-f6a1-4b28-9b58-8e1b7c479a57",
                column: "ConcurrencyStamp",
                value: "5179635b-4c14-4a62-9f8d-e51fe5d9db6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45c576b6-f6a1-4b28-9b58-8e1b7c479b57",
                column: "ConcurrencyStamp",
                value: "4ebf3e70-720d-4176-9aa7-1d0a11777652");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c280b6-f6a1-4b66-9b56-8e1b7a479a57",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d178c1ba-69f0-4898-9a66-30e4df91ea7f", false, null, "AQAAAAEAACcQAAAAENTJURTN/sgh7zxtUFLfSMxCY1z3uiPe18OgQrVDlyOu5CJgsTB/E3hIyAY01FtUsg==", "f9c4abd9-673b-4006-8413-05a85d5425bd", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c290b6-f6a1-4b66-9d56-8e1b7a333a57",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "04d55ea9-5eaa-4aae-a609-6db5d1f84572", false, null, "AQAAAAEAACcQAAAAEJfUbgslNAb4L4R5/NetIkcgV5s0RimBBfto0dSdJgqFA+JTmhqFF2urKFHq+Gkrwg==", "bfdfd92d-ad4a-4e0e-ac6b-d97fe27094af", null });
        }
    }
}
