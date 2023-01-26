using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerOffice.Data.EF.Migrations
{
    public partial class fixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lawyer_on_case_Lawyer_Owner_LawyerId",
                table: "Lawyer_on_case");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lawyer",
                table: "Lawyer");

            migrationBuilder.RenameTable(
                name: "Lawyer",
                newName: "Lawyers");

            migrationBuilder.AlterColumn<decimal>(
                name: "Billing_case",
                table: "Lawyer_on_case",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Hourly_rate",
                table: "Lawyers",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lawyers",
                table: "Lawyers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyer_on_case_Lawyers_Owner_LawyerId",
                table: "Lawyer_on_case",
                column: "Owner_LawyerId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lawyer_on_case_Lawyers_Owner_LawyerId",
                table: "Lawyer_on_case");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lawyers",
                table: "Lawyers");

            migrationBuilder.RenameTable(
                name: "Lawyers",
                newName: "Lawyer");

            migrationBuilder.AlterColumn<decimal>(
                name: "Billing_case",
                table: "Lawyer_on_case",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Hourly_rate",
                table: "Lawyer",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lawyer",
                table: "Lawyer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyer_on_case_Lawyer_Owner_LawyerId",
                table: "Lawyer_on_case",
                column: "Owner_LawyerId",
                principalTable: "Lawyer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
