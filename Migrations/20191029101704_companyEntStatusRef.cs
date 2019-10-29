using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class companyEntStatusRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_CompanyStatuse_StatusCompanyStatusID",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_StatusCompanyStatusID",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "StatusCompanyStatusID",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "CompanyStatusID",
                table: "Company",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Company_CompanyStatusID",
                table: "Company",
                column: "CompanyStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_CompanyStatuse_CompanyStatusID",
                table: "Company",
                column: "CompanyStatusID",
                principalTable: "CompanyStatuse",
                principalColumn: "CompanyStatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_CompanyStatuse_CompanyStatusID",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_CompanyStatusID",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompanyStatusID",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "StatusCompanyStatusID",
                table: "Company",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_StatusCompanyStatusID",
                table: "Company",
                column: "StatusCompanyStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_CompanyStatuse_StatusCompanyStatusID",
                table: "Company",
                column: "StatusCompanyStatusID",
                principalTable: "CompanyStatuse",
                principalColumn: "CompanyStatusID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
