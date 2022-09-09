using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementApp.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35c786b6-f6a1-4b28-9b58-8e1b7c479a57", "5179635b-4c14-4a62-9f8d-e51fe5d9db6a", "Administrator", "ADMINISTRATOR" },
                    { "45c576b6-f6a1-4b28-9b58-8e1b7c479b57", "4ebf3e70-720d-4176-9aa7-1d0a11777652", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "35c280b6-f6a1-4b66-9b56-8e1b7a479a57", 0, "d178c1ba-69f0-4898-9a66-30e4df91ea7f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@yopmail.com", false, "System", "Admin", false, null, "ADMIN@YOPMAIL.COM", null, "AQAAAAEAACcQAAAAENTJURTN/sgh7zxtUFLfSMxCY1z3uiPe18OgQrVDlyOu5CJgsTB/E3hIyAY01FtUsg==", null, false, "f9c4abd9-673b-4006-8413-05a85d5425bd", null, false, null },
                    { "35c290b6-f6a1-4b66-9d56-8e1b7a333a57", 0, "04d55ea9-5eaa-4aae-a609-6db5d1f84572", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@yopmail.com", false, "System", "User", false, null, "USER@YOPMAIL.COM", null, "AQAAAAEAACcQAAAAEJfUbgslNAb4L4R5/NetIkcgV5s0RimBBfto0dSdJgqFA+JTmhqFF2urKFHq+Gkrwg==", null, false, "bfdfd92d-ad4a-4e0e-ac6b-d97fe27094af", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "35c786b6-f6a1-4b28-9b58-8e1b7c479a57", "35c280b6-f6a1-4b66-9b56-8e1b7a479a57" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "45c576b6-f6a1-4b28-9b58-8e1b7c479b57", "35c290b6-f6a1-4b66-9d56-8e1b7a333a57" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "35c786b6-f6a1-4b28-9b58-8e1b7c479a57", "35c280b6-f6a1-4b66-9b56-8e1b7a479a57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "45c576b6-f6a1-4b28-9b58-8e1b7c479b57", "35c290b6-f6a1-4b66-9d56-8e1b7a333a57" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35c786b6-f6a1-4b28-9b58-8e1b7c479a57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45c576b6-f6a1-4b28-9b58-8e1b7c479b57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c280b6-f6a1-4b66-9b56-8e1b7a479a57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35c290b6-f6a1-4b66-9d56-8e1b7a333a57");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
