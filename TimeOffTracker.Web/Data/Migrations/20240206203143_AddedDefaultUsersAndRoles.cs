using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeOffTracker.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cc9e3ff-0a5c-4a16-82af-da058d968180", "ec26c7c9-1e4a-4a54-b1e4-950a62e7ea0b", "Administrator", "ADMINISTRATOR" },
                    { "571056d2-b48d-4474-95fe-ba0f4b01225e", "6c8fb14b-3888-4788-b582-81f7d07fed76", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "778e5a26-f556-40be-83c9-a2c47af93338", 0, "acb7f9ed-5c7c-45e8-bbc4-fbbc1d4135a0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEKBASDUqbL6TCPKte0Y5vFjzf3qHKcPcCm0IlWaepeDpgJ70uA/R8omwd3H03VGh0g==", null, false, "72fa7fc5-ac5d-4b3a-8d39-b506c6e2f7b3", false, null },
                    { "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34", 0, "fd5c84cd-5d00-45a8-be35-c03b60284b84", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEIGsP4hOB9LX9zYyx35Fj+bS36fdnQUGECexod0nEOs1+j0jb0ja2/qPRJMXKpzuRQ==", null, false, "bc62aebf-0c56-4907-9cb7-49d635314051", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "571056d2-b48d-4474-95fe-ba0f4b01225e", "778e5a26-f556-40be-83c9-a2c47af93338" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2cc9e3ff-0a5c-4a16-82af-da058d968180", "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "571056d2-b48d-4474-95fe-ba0f4b01225e", "778e5a26-f556-40be-83c9-a2c47af93338" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2cc9e3ff-0a5c-4a16-82af-da058d968180", "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cc9e3ff-0a5c-4a16-82af-da058d968180");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "571056d2-b48d-4474-95fe-ba0f4b01225e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "778e5a26-f556-40be-83c9-a2c47af93338");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34");

            migrationBuilder.AddColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
