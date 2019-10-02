using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class PartnerInfoUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CityID",
                table: "PartnerInfos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "PartnerInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityID",
                table: "PartnerInfos");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "PartnerInfos");
        }
    }
}
