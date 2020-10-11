using Microsoft.EntityFrameworkCore.Migrations;

namespace Term_Project_Version_1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 30, nullable: false),
                    email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Price = table.Column<string>(nullable: true),
                    MembersID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Membership",
                columns: new[] { "ID", "email", "name" },
                values: new object[,]
                {
                    { 1, "michelle@vanwetteregroup.com", "Michelle Vanwettere" },
                    { 2, "tito.nugaily@gmail.com", "Tito Nugauily" },
                    { 3, "david.wood@acts17.com", "David Wood" },
                    { 4, "mgibson@makeitrain.com", "Matthew Gibson" },
                    { 5, "mohamedayew@gmail.com", "Mohamed Ayew" },
                    { 6, "mayadamohamed@gmail.com", "Meda Doyle" }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "ID", "MembersID", "Price" },
                values: new object[,]
                {
                    { "SA", 1, "$19.99" },
                    { "FS", 6, "$79.99" },
                    { "FA", 5, "$109.99" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Membership");

            migrationBuilder.DropTable(
                name: "Purchases");
        }
    }
}
