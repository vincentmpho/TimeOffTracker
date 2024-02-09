using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeOffTracker.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
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
                keyValue: "2cc9e3ff-0a5c-4a16-82af-da058d968180",
                column: "ConcurrencyStamp",
                value: "649858ff-c459-4dba-9956-e91d758dc659");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "571056d2-b48d-4474-95fe-ba0f4b01225e",
                column: "ConcurrencyStamp",
                value: "5641f4d4-9b24-4579-b1e1-b242e883bdba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "778e5a26-f556-40be-83c9-a2c47af93338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c2ca785-c123-4253-b6d9-ce11a82fca22", "AQAAAAEAACcQAAAAEBCHpvl2u67H/YUymIOrF3v2dXlFMLUfSDe378zbKo43di3jeJwOqg/PiF6xSOHHqQ==", "c1f7b760-541a-4479-ac0e-34c5ad2f1029" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d284bc6a-c144-4003-b3a2-3398082edb0c", "AQAAAAEAACcQAAAAEOKk8Ph8IZb0nVE1a4KhfAeqEu7nTJr32wd8NjlHHmZgJLHKyDbmI0cSb/Al1QLRzQ==", "4cfa1826-dead-4a9f-9a42-8f8289eca5f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e64c586-e140-4b07-b63b-4ca518e65efd", "AQAAAAEAACcQAAAAEJj/ioUhkbzKl2jRjUXsC25vS2AwedOrlKfWjS7Mq6ikhU1KNED028pjUimrdOMieQ==", "32a2eac8-c22e-4768-89ef-77bf668e6578" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c48f390-c55f-48d7-83da-109beeb18c1e", "AQAAAAEAACcQAAAAEOyAWMV8S+BZwG4joZdCu8Poqi9sU3Q7tSMKD4KQML2ZkiO6+rlm3wTFo8NWWn3VvQ==", "81ae9f7c-ef17-4001-bbd2-82a68b14518a" });
        }
    }
}
