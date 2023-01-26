using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerOffice.Data.EF.Migrations
{
    public partial class tststr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lawyer_on_case_Lawyer_Owner_lawyerId",
                table: "Lawyer_on_case");

            migrationBuilder.RenameColumn(
                name: "Owner_lawyerId",
                table: "Lawyer_on_case",
                newName: "Owner_LawyerId");

            migrationBuilder.RenameIndex(
                name: "IX_Lawyer_on_case_Owner_lawyerId",
                table: "Lawyer_on_case",
                newName: "IX_Lawyer_on_case_Owner_LawyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyer_on_case_Lawyer_Owner_LawyerId",
                table: "Lawyer_on_case",
                column: "Owner_LawyerId",
                principalTable: "Lawyer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lawyer_on_case_Lawyer_Owner_LawyerId",
                table: "Lawyer_on_case");

            migrationBuilder.RenameColumn(
                name: "Owner_LawyerId",
                table: "Lawyer_on_case",
                newName: "Owner_lawyerId");

            migrationBuilder.RenameIndex(
                name: "IX_Lawyer_on_case_Owner_LawyerId",
                table: "Lawyer_on_case",
                newName: "IX_Lawyer_on_case_Owner_lawyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyer_on_case_Lawyer_Owner_lawyerId",
                table: "Lawyer_on_case",
                column: "Owner_lawyerId",
                principalTable: "Lawyer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
