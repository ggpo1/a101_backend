using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class name123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyID",
                table: "Document",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Document_CompanyID",
                table: "Document",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Company_CompanyID",
                table: "Document",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Company_CompanyID",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_CompanyID",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "CompanyID",
                table: "Document");
        }
    }
}
