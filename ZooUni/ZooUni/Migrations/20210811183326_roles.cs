using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooUni.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2e579ec-f1ca-414c-ac55-7deadaca78c5", "fd422712-4ccd-4cd5-9e91-fc36813555fe", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81fbf64e-0118-4ece-9928-50832610bc1a", "3f1b342f-c3a6-4ed8-abda-12724bc15206", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81fbf64e-0118-4ece-9928-50832610bc1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2e579ec-f1ca-414c-ac55-7deadaca78c5");
        }
    }
}
