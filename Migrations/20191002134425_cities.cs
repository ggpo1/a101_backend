using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class cities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID1",
                table: "PartnerInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "PartnerInfos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfos_Cities_CityID1",
                table: "PartnerInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PartnerInfos_Users_UserID1",
                table: "PartnerInfos");

            migrationBuilder.DropTable(
                name: "Cities");

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
        }
    }
}
