using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerOffice.Data.EF.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "eae7a027-e8bf-47cf-aaa9-2c611ac3f0da", "68e82a11-231f-4c1a-87a2-7debfa60cac8", "User", "USER" },
                    { "b00045d0-c578-4330-b5cf-7666dc877728", "23e88b45-d790-4ae2-8cce-080d6e09e9fe", "Administrator", "ADMINISTRATOR" },
                    { "265a455c-7db1-4d0d-8c62-a163376426fd", "746d559f-f17a-47fa-9da5-c0da07d4ef9e", "Visitor", "VISITOR" },
                    { "a637799d-b83f-406d-91d6-03da2dec350e", "b4af2903-f2dc-408a-935c-65c3a5dcd385", "Viewer", "VIEWER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "265a455c-7db1-4d0d-8c62-a163376426fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a637799d-b83f-406d-91d6-03da2dec350e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b00045d0-c578-4330-b5cf-7666dc877728");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae7a027-e8bf-47cf-aaa9-2c611ac3f0da");
        }
    }
}
