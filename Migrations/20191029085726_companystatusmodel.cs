using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class companystatusmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "StatusCompanyStatusID",
                table: "Company",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyStatuse",
                columns: table => new
                {
                    CompanyStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyStatusName = table.Column<string>(nullable: true),
                    CompanyStatusColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyStatuse", x => x.CompanyStatusID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_CompanyStatuse_StatusCompanyStatusID",
                table: "Company");

            migrationBuilder.DropTable(
                name: "CompanyStatuse");

            migrationBuilder.DropIndex(
                name: "IX_Company_StatusCompanyStatusID",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "StatusCompanyStatusID",
                table: "Company");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Company",
                nullable: false,
                defaultValue: 0);
        }
    }
}
