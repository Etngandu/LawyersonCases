using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerOffice.Data.EF.Migrations
{
    public partial class @case : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lawyer_on_case_Case_Owner_CaseId",
                table: "Lawyer_on_case");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Case",
                table: "Case");

            migrationBuilder.RenameTable(
                name: "Case",
                newName: "Cases");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cases",
                table: "Cases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyer_on_case_Cases_Owner_CaseId",
                table: "Lawyer_on_case",
                column: "Owner_CaseId",
                principalTable: "Cases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lawyer_on_case_Cases_Owner_CaseId",
                table: "Lawyer_on_case");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cases",
                table: "Cases");

            migrationBuilder.RenameTable(
                name: "Cases",
                newName: "Case");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Case",
                table: "Case",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyer_on_case_Case_Owner_CaseId",
                table: "Lawyer_on_case",
                column: "Owner_CaseId",
                principalTable: "Case",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
