using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeOffTracker.Web.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cc9e3ff-0a5c-4a16-82af-da058d968180",
                column: "ConcurrencyStamp",
                value: "60eaacfe-d2b3-4154-8296-914eebdac30a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "571056d2-b48d-4474-95fe-ba0f4b01225e",
                column: "ConcurrencyStamp",
                value: "9d89727b-8c0a-4f79-a4d2-eb92831094c9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "778e5a26-f556-40be-83c9-a2c47af93338",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33a93258-9516-402d-9ea2-e2cb5cdd3657", "AQAAAAEAACcQAAAAEBbt3PoQ28o64O9iGuK3p2eKQnITNneNeIJ+w6v0acxcaHwmvnEXDHBSI6mkE2kQ9A==", "748271dd-8f9f-4133-8f83-9f85c5ecf8d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb8e99c9-b5d7-49f6-bf1e-f8a001cddb34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47299723-4123-4f82-993c-f9b604928ad1", "AQAAAAEAACcQAAAAEAhTh6j+KjWKUUTGTvWgr4StYZFDl15DFwrECiWrc08Jvy8klTJ1zCoLTwBgWH1tcg==", "50d78670-4cef-4e05-84d2-a91b9f1a5493" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
