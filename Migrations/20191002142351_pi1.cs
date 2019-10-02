using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class pi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_PartnerInfos_PartnerInfoID",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Companies");

            migrationBuilder.AlterColumn<int>(
                name: "PartnerInfoID",
                table: "Companies",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_PartnerInfos_PartnerInfoID",
                table: "Companies",
                column: "PartnerInfoID",
                principalTable: "PartnerInfos",
                principalColumn: "PartnerInfoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_PartnerInfos_PartnerInfoID",
                table: "Companies");

            migrationBuilder.AlterColumn<int>(
                name: "PartnerInfoID",
                table: "Companies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Companies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_PartnerInfos_PartnerInfoID",
                table: "Companies",
                column: "PartnerInfoID",
                principalTable: "PartnerInfos",
                principalColumn: "PartnerInfoID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
