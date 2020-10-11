using Microsoft.EntityFrameworkCore.Migrations;

namespace Term_Project_Version_1.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Purchases_MembersID",
                table: "Purchases",
                column: "MembersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Membership_MembersID",
                table: "Purchases",
                column: "MembersID",
                principalTable: "Membership",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Membership_MembersID",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_MembersID",
                table: "Purchases");
        }
    }
}
