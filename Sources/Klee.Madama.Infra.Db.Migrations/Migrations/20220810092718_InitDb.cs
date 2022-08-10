using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Klee.Madama.Infra.Db.Migrations.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorie_techno",
                columns: table => new
                {
                    cte_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    cte_libelle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorie_techno", x => x.cte_code);
                });

            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    clt_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clt_nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.clt_id);
                });

            migrationBuilder.CreateTable(
                name: "personne",
                columns: table => new
                {
                    prs_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prs_nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    prs_prenom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    prs_courriel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personne", x => x.prs_id);
                });

            migrationBuilder.CreateTable(
                name: "poste",
                columns: table => new
                {
                    pst_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    pst_libelle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_poste", x => x.pst_code);
                });

            migrationBuilder.CreateTable(
                name: "role_projet",
                columns: table => new
                {
                    rlp_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    rlp_libelle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role_projet", x => x.rlp_code);
                });

            migrationBuilder.CreateTable(
                name: "techno",
                columns: table => new
                {
                    tec_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tec_nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cte_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_techno", x => x.tec_id);
                    table.ForeignKey(
                        name: "FK_techno_categorie_techno_cte_code",
                        column: x => x.cte_code,
                        principalTable: "categorie_techno",
                        principalColumn: "cte_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "projet",
                columns: table => new
                {
                    prj_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prj_nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    clt_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projet", x => x.prj_id);
                    table.ForeignKey(
                        name: "FK_projet_client_clt_id",
                        column: x => x.clt_id,
                        principalTable: "client",
                        principalColumn: "clt_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "version_techno",
                columns: table => new
                {
                    vte_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vte_nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    tec_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_version_techno", x => x.vte_id);
                    table.ForeignKey(
                        name: "FK_version_techno_techno_tec_id",
                        column: x => x.tec_id,
                        principalTable: "techno",
                        principalColumn: "tec_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "categorie_techno",
                columns: new[] { "cte_code", "cte_libelle" },
                values: new object[,]
                {
                    { "BACK", "Back" },
                    { "CICD", "CI/CD" },
                    { "FRONT", "Front" },
                    { "INFRA", "Infra" }
                });

            migrationBuilder.InsertData(
                table: "poste",
                columns: new[] { "pst_code", "pst_libelle" },
                values: new object[,]
                {
                    { "ARCHI", "Architecte" },
                    { "CHEF_PRJ", "Chef·fe de projet" },
                    { "DEV", "Développeur·se" },
                    { "LEAD_TECH", "Leader technique" }
                });

            migrationBuilder.InsertData(
                table: "role_projet",
                columns: new[] { "rlp_code", "rlp_libelle" },
                values: new object[,]
                {
                    { "ARCHI", "Architecte" },
                    { "CHEF_PRJ", "Chef·fe de projet" },
                    { "DEV", "Développeur·se" },
                    { "REF_FONC", "Référent fonctionnel" },
                    { "REF_TECH", "Référent technique" },
                    { "SCRUM_MST", "Scrum master" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_projet_clt_id",
                table: "projet",
                column: "clt_id");

            migrationBuilder.CreateIndex(
                name: "IX_techno_cte_code",
                table: "techno",
                column: "cte_code");

            migrationBuilder.CreateIndex(
                name: "IX_version_techno_tec_id",
                table: "version_techno",
                column: "tec_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personne");

            migrationBuilder.DropTable(
                name: "poste");

            migrationBuilder.DropTable(
                name: "projet");

            migrationBuilder.DropTable(
                name: "role_projet");

            migrationBuilder.DropTable(
                name: "version_techno");

            migrationBuilder.DropTable(
                name: "client");

            migrationBuilder.DropTable(
                name: "techno");

            migrationBuilder.DropTable(
                name: "categorie_techno");
        }
    }
}
