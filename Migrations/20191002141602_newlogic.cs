using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class newlogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Users_UserID",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_UserID",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Companies");

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonFullName",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonPhoneNumber",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartnerInfoID",
                table: "Companies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityID",
                table: "Companies",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PartnerInfoID",
                table: "Companies",
                column: "PartnerInfoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Cities_CityID",
                table: "Companies",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_PartnerInfos_PartnerInfoID",
                table: "Companies",
                column: "PartnerInfoID",
                principalTable: "PartnerInfos",
                principalColumn: "PartnerInfoID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Cities_CityID",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_PartnerInfos_PartnerInfoID",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_CityID",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_PartnerInfoID",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ContactPersonFullName",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ContactPersonPhoneNumber",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "PartnerInfoID",
                table: "Companies");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Companies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UserID",
                table: "Companies",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_UserID",
                table: "Companies",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
