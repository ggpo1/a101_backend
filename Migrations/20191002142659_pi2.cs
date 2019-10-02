using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class pi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Cities_CityID",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_PartnerInfos_PartnerInfoID",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfos_Cities_CityID",
                table: "PartnerInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfos_Users_UserID",
                table: "PartnerInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartnerInfos",
                table: "PartnerInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "PartnerInfos",
                newName: "PartnerInfo");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerInfos_UserID",
                table: "PartnerInfo",
                newName: "IX_PartnerInfo_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerInfos_CityID",
                table: "PartnerInfo",
                newName: "IX_PartnerInfo_CityID");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_PartnerInfoID",
                table: "Company",
                newName: "IX_Company_PartnerInfoID");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_CityID",
                table: "Company",
                newName: "IX_Company_CityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartnerInfo",
                table: "PartnerInfo",
                column: "PartnerInfoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_City_CityID",
                table: "Company",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_PartnerInfo_PartnerInfoID",
                table: "Company",
                column: "PartnerInfoID",
                principalTable: "PartnerInfo",
                principalColumn: "PartnerInfoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerInfo_City_CityID",
                table: "PartnerInfo",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartnerInfo_User_UserID",
                table: "PartnerInfo",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_City_CityID",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_PartnerInfo_PartnerInfoID",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfo_City_CityID",
                table: "PartnerInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfo_User_UserID",
                table: "PartnerInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartnerInfo",
                table: "PartnerInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "PartnerInfo",
                newName: "PartnerInfos");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerInfo_UserID",
                table: "PartnerInfos",
                newName: "IX_PartnerInfos_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_PartnerInfo_CityID",
                table: "PartnerInfos",
                newName: "IX_PartnerInfos_CityID");

            migrationBuilder.RenameIndex(
                name: "IX_Company_PartnerInfoID",
                table: "Companies",
                newName: "IX_Companies_PartnerInfoID");

            migrationBuilder.RenameIndex(
                name: "IX_Company_CityID",
                table: "Companies",
                newName: "IX_Companies_CityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartnerInfos",
                table: "PartnerInfos",
                column: "PartnerInfoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Cities_CityID",
                table: "Companies",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_PartnerInfos_PartnerInfoID",
                table: "Companies",
                column: "PartnerInfoID",
                principalTable: "PartnerInfos",
                principalColumn: "PartnerInfoID",
                onDelete: ReferentialAction.Cascade);

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
    }
}
