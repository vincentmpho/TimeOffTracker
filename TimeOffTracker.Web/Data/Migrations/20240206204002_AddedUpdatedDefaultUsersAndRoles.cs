using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeOffTracker.Web.Data.Migrations
{
    public partial class AddedUpdatedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cc9e3ff-0a5c-4a16-82af-da058d968180",
                column: "ConcurrencyStamp",
                value: "0a9fab9c-802f-4667-908e-5d054a090731");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "571056d2-b48d-4474-95fe-ba0f4b01225e",
                column: "ConcurrencyStamp",
                value: "7f517ba3-9f2e-486a-ab5c-252d490140d9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "778e5a26-f556-40be-83c9-a2c47af93338",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1e64c586-e140-4b07-b63b-4ca518e65efd", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJj/ioUhkbzKl2jRjUXsC25vS2AwedOrlKfWjS7Mq6ikhU1KNED028pjUimrdOMieQ==", "32a2eac8-c22e-4768-89ef-77bf668e6578", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0c48f390-c55f-48d7-83da-109beeb18c1e", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOyAWMV8S+BZwG4joZdCu8Poqi9sU3Q7tSMKD4KQML2ZkiO6+rlm3wTFo8NWWn3VvQ==", "81ae9f7c-ef17-4001-bbd2-82a68b14518a", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cc9e3ff-0a5c-4a16-82af-da058d968180",
                column: "ConcurrencyStamp",
                value: "ec26c7c9-1e4a-4a54-b1e4-950a62e7ea0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "571056d2-b48d-4474-95fe-ba0f4b01225e",
                column: "ConcurrencyStamp",
                value: "6c8fb14b-3888-4788-b582-81f7d07fed76");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "778e5a26-f556-40be-83c9-a2c47af93338",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "acb7f9ed-5c7c-45e8-bbc4-fbbc1d4135a0", false, null, "AQAAAAEAACcQAAAAEKBASDUqbL6TCPKte0Y5vFjzf3qHKcPcCm0IlWaepeDpgJ70uA/R8omwd3H03VGh0g==", "72fa7fc5-ac5d-4b3a-8d39-b506c6e2f7b3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fd5c84cd-5d00-45a8-be35-c03b60284b84", false, null, "AQAAAAEAACcQAAAAEIGsP4hOB9LX9zYyx35Fj+bS36fdnQUGECexod0nEOs1+j0jb0ja2/qPRJMXKpzuRQ==", "bc62aebf-0c56-4907-9cb7-49d635314051", null });
        }
    }
}
