using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_Company_CompanyID",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_PartnerInfo_PartnerInfoID",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_CompanyID",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_PartnerInfoID",
                table: "Document");

            migrationBuilder.AlterColumn<int>(
                name: "PartnerInfoID",
                table: "Document",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID",
                table: "Document",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PartnerInfoID",
                table: "Document",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID",
                table: "Document",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Document_CompanyID",
                table: "Document",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Document_PartnerInfoID",
                table: "Document",
                column: "PartnerInfoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Company_CompanyID",
                table: "Document",
                column: "CompanyID",
                principalTable: "Company",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_PartnerInfo_PartnerInfoID",
                table: "Document",
                column: "PartnerInfoID",
                principalTable: "PartnerInfo",
                principalColumn: "PartnerInfoID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
