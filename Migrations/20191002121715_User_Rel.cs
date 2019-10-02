using Microsoft.EntityFrameworkCore.Migrations;

namespace a101_backend.Migrations
{
    public partial class User_Rel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Users_UserID",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_UserID",
                table: "Companies");
        }
    }
}
