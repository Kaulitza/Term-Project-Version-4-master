using Microsoft.EntityFrameworkCore.Migrations;

namespace Term_Project_Version_1.Migrations
{
    public partial class PurchaseDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Purchases");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Purchases",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "ID",
                keyValue: "FA",
                column: "Description",
                value: "Full Access including study guide and access to all podcasts and articles");

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "ID",
                keyValue: "SA",
                column: "Description",
                value: "Seeking Allah Finding Jesus Paperback");

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "ID",
                keyValue: "SG",
                column: "Description",
                value: "Study Guide including hard cover book, study guide and blu-ray");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Purchases");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Purchases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "ID",
                keyValue: "FA",
                column: "Name",
                value: "Full Access including study guide and access to all podcasts and articles");

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "ID",
                keyValue: "SA",
                column: "Name",
                value: "Seeking Allah Finding Jesus Paperback");

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "ID",
                keyValue: "SG",
                column: "Name",
                value: "Study Guide including hard cover book, study guide and blu-ray");
        }
    }
}
