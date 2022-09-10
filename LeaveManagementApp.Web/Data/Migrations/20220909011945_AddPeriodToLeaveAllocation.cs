using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementApp.Web.Data.Migrations
{
    public partial class AddPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35c786b6-f6a1-4b28-9b58-8e1b7c479a57",
                column: "ConcurrencyStamp",
                value: "e989d9be-9df4-4865-b0ac-3e843af0173c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45c576b6-f6a1-4b28-9b58-8e1b7c479b57",
                column: "ConcurrencyStamp",
                value: "2c686a5f-2cba-48e1-9e46-4df16c9125a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c280b6-f6a1-4b66-9b56-8e1b7a479a57",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a463fa65-a63c-4375-ae56-0e55c206dfb9", "AQAAAAEAACcQAAAAEGlIN6BBjJLxn/nFXu1O+tsi2QIRVSe/sO7ndy/Lz0WJ5L9GCbcTzclh7Ud1bXWyWQ==", "55df3742-981c-40b9-80fd-0c301b0ed571" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c290b6-f6a1-4b66-9d56-8e1b7a333a57",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "452dfd73-0d45-45ec-b858-e5801bfc2e8b", "AQAAAAEAACcQAAAAEDXqnRnUjUTuL5iubeB+MHFCTV1DTW4P+ePzIStcYr4c2HF+mNRdnSbSkuO/6Hvp/A==", "6859c97e-d957-47fe-af9f-839767361494" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "437429cf-7c17-4300-bff2-e82e53c53766", "AQAAAAEAACcQAAAAEKYYQvBpnpJ4jJDYK1UlrhVloB1ma0BmgKiTZ6luYvP35f0FTxV6ICIw7X1/g8GgGA==", "6a573f44-e7cf-49c1-a862-ad9ab0cbc00a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c290b6-f6a1-4b66-9d56-8e1b7a333a57",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27a75991-1677-41be-a01b-08a24d40f030", "AQAAAAEAACcQAAAAEJOF1SsNhTKmGF62rqKoD0iYgwvgz6PEJ14dtBHR6MGg3LIPWiF6Y8RisQcaWOgukg==", "8e6976f8-7ee0-4e01-9031-c96a18ced351" });
        }
    }
}
