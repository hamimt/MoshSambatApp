using Microsoft.EntityFrameworkCore.Migrations;

namespace MoshApp.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make2')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make3')");

            migrationBuilder.Sql("INSERT INTO ModeMake1-ModelA', 1)");
            migrationBuilder.Sql("INSERT INTO ModeMake1-ModelB', 1)");
            migrationBuilder.Sql("INSERT INTO ModeMake1-ModelC', 1)");

            migrationBuilder.Sql("INSERT INTO ModeMake2-ModelA', 2)");
            migrationBuilder.Sql("INSERT INTO ModeMake2-ModelB', 2)");
            migrationBuilder.Sql("INSERT INTO ModeMake2-ModelC', 2)");

            
            migrationBuilder.Sql("INSERT INTO ModeMake3-ModelA', 3)");
            migrationBuilder.Sql("INSERT INTO ModeMake3-ModelB', 3)");
            migrationBuilder.Sql("INSERT INTO ModeMake3-ModelC', 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
        }
    }
}
