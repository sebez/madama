using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Klee.Madama.Infra.Db.Migrations.Migrations
{
    public partial class AddDbCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categorie_techno",
                columns: new[] { "cte_code", "cte_libelle" },
                values: new object[] { "DB", "Database" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categorie_techno",
                keyColumn: "cte_code",
                keyValue: "DB");
        }
    }
}
