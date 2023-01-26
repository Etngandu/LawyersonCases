using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LawyerOffice.Data.EF.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Case_Opened_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Case_Closed_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Case_description = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Other_case_details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Statuscase = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lawyer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hourly_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qualications = table.Column<int>(type: "int", nullable: false),
                    Speciality = table.Column<int>(type: "int", nullable: false),
                    EmailAddres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawyer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lawyer_on_case",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner_lawyerId = table.Column<int>(type: "int", nullable: false),
                    Owner_CaseId = table.Column<int>(type: "int", nullable: false),
                    Reference_role = table.Column<int>(type: "int", nullable: false),
                    Case_status = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Billing_case = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawyer_on_case", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lawyer_on_case_Case_Owner_CaseId",
                        column: x => x.Owner_CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lawyer_on_case_Lawyer_Owner_lawyerId",
                        column: x => x.Owner_lawyerId,
                        principalTable: "Lawyer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lawyer_on_case_Owner_CaseId",
                table: "Lawyer_on_case",
                column: "Owner_CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lawyer_on_case_Owner_lawyerId",
                table: "Lawyer_on_case",
                column: "Owner_lawyerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lawyer_on_case");

            migrationBuilder.DropTable(
                name: "Case");

            migrationBuilder.DropTable(
                name: "Lawyer");
        }
    }
}
