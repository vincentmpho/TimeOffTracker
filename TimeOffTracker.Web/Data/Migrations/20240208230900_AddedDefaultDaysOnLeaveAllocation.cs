using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeOffTracker.Web.Data.Migrations
{
    public partial class AddedDefaultDaysOnLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultDays",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cc9e3ff-0a5c-4a16-82af-da058d968180",
                column: "ConcurrencyStamp",
                value: "8d782581-a1cc-4cbd-a2f2-64e858bad930");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "571056d2-b48d-4474-95fe-ba0f4b01225e",
                column: "ConcurrencyStamp",
                value: "37e87fdb-d016-4a6c-881f-6438c99db17a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "778e5a26-f556-40be-83c9-a2c47af93338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f41f8771-3b2b-43ab-ac8f-99a1648bd587", "AQAAAAEAACcQAAAAEPZzVrmmr17Xwt41sfc/JVTNeNjFZnzHiWhlAoJWyxi5MEqrpiRCM/wFr7/9uT2/bQ==", "1cf41d60-601b-49c5-b752-5bf25fb4d293" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6986e62d-dd0b-411e-b8a0-c9f35f3974ce", "AQAAAAEAACcQAAAAECxe8E1j6T3POoFg1kfnraZKSZ/tNKGxibJBpP92GoMJ1Za4COTIKDy6oe8jsypeXA==", "0b04bec6-74fb-415a-a45e-570cb7956017" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultDays",
                table: "LeaveAllocations");

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
    }
}
