using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeOffTracker.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: true),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cc9e3ff-0a5c-4a16-82af-da058d968180",
                column: "ConcurrencyStamp",
                value: "34b02d14-de8f-451e-9013-844fb5c667ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "571056d2-b48d-4474-95fe-ba0f4b01225e",
                column: "ConcurrencyStamp",
                value: "da71d5a1-a102-4651-8c2f-491a3b8302ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "778e5a26-f556-40be-83c9-a2c47af93338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6168bf22-bcf3-423e-9307-0d763ac0121a", "AQAAAAEAACcQAAAAEFR8UlAZ3Q129y73YYq0ds0dtc/dqA15pxlxAGLmC+tXP+gSLf2yEtKMVpCkSkk5/Q==", "6b320034-9d90-4805-af6d-2ffcb6953676" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e42f993-a382-4f58-b89a-a6337bb42d81", "AQAAAAEAACcQAAAAEKajWdQsCX+3S7jcGaSIIglnHh/2XE9hMCTeNgTLkApgrSHUoT8toECSUFd61SaK6A==", "addc8834-0a74-461d-809a-0070a124dcd1" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
