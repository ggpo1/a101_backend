using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class CompanyName1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfos_Cities_CityID1",
                table: "PartnerInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfos_Users_UserID1",
                table: "PartnerInfos");

            migrationBuilder.DropIndex(
                name: "IX_PartnerInfos_CityID1",
                table: "PartnerInfos");

            migrationBuilder.DropIndex(
                name: "IX_PartnerInfos_UserID1",
                table: "PartnerInfos");

            migrationBuilder.DropColumn(
                name: "CityID1",
                table: "PartnerInfos");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "PartnerInfos");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "PartnerInfos",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityID",
                table: "PartnerInfos",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartnerInfos_CityID",
                table: "PartnerInfos",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerInfos_UserID",
                table: "PartnerInfos",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerInfos_Cities_CityID",
                table: "PartnerInfos",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerInfos_Users_UserID",
                table: "PartnerInfos",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfos_Cities_CityID",
                table: "PartnerInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfos_Users_UserID",
                table: "PartnerInfos");

            migrationBuilder.DropIndex(
                name: "IX_PartnerInfos_CityID",
                table: "PartnerInfos");

            migrationBuilder.DropIndex(
                name: "IX_PartnerInfos_UserID",
                table: "PartnerInfos");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "PartnerInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CityID",
                table: "PartnerInfos",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityID1",
                table: "PartnerInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "PartnerInfos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartnerInfos_CityID1",
                table: "PartnerInfos",
                column: "CityID1");

            migrationBuilder.CreateIndex(
                name: "IX_PartnerInfos_UserID1",
                table: "PartnerInfos",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerInfos_Cities_CityID1",
                table: "PartnerInfos",
                column: "CityID1",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerInfos_Users_UserID1",
                table: "PartnerInfos",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
