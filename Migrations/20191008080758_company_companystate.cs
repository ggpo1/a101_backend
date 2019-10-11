using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class company_companystate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactPersonCompanyState",
                table: "Company",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactPersonCompanyState",
                table: "Company");
        }
    }
}
