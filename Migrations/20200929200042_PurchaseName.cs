using Microsoft.EntityFrameworkCore.Migrations;

namespace Term_Project_Version_1.Migrations
{
    public partial class PurchaseName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "ID",
                keyValue: "FS");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Purchases",
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

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "ID", "MembersID", "Name", "Price" },
                values: new object[] { "SG", 6, "Study Guide including hard cover book, study guide and blu-ray", "$79.99" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "ID",
                keyValue: "SG");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Purchases");

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "ID", "MembersID", "Price" },
                values: new object[] { "FS", 6, "$79.99" });
        }
    }
}
