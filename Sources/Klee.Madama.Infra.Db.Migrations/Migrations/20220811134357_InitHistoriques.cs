using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Klee.Madama.Infra.Db.Migrations.Migrations
{
    public partial class InitHistoriques : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pst_code",
                table: "personne",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "personne_techno",
                columns: table => new
                {
                    prt_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prs_id = table.Column<int>(type: "int", nullable: false),
                    vte_id = table.Column<int>(type: "int", nullable: false),
                    prt_date_debut = table.Column<DateTime>(type: "date", nullable: false),
                    prt_date_fin = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personne_techno", x => x.prt_id);
                    table.ForeignKey(
                        name: "FK_personne_techno_personne_prs_id",
                        column: x => x.prs_id,
                        principalTable: "personne",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personne_techno_version_techno_vte_id",
                        column: x => x.vte_id,
                        principalTable: "version_techno",
                        principalColumn: "vte_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "projet_personne",
                columns: table => new
                {
                    pps_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prj_id = table.Column<int>(type: "int", nullable: false),
                    prs_id = table.Column<int>(type: "int", nullable: false),
                    rlp_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    pps_date_debut = table.Column<DateTime>(type: "date", nullable: false),
                    pps_date_fin = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projet_personne", x => x.pps_id);
                    table.ForeignKey(
                        name: "FK_projet_personne_personne_prs_id",
                        column: x => x.prs_id,
                        principalTable: "personne",
                        principalColumn: "prs_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_projet_personne_projet_prj_id",
                        column: x => x.prj_id,
                        principalTable: "projet",
                        principalColumn: "prj_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_projet_personne_role_projet_rlp_code",
                        column: x => x.rlp_code,
                        principalTable: "role_projet",
                        principalColumn: "rlp_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "projet_techno",
                columns: table => new
                {
                    pte_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prj_id = table.Column<int>(type: "int", nullable: false),
                    vte_id = table.Column<int>(type: "int", nullable: false),
                    pte_date_debut = table.Column<DateTime>(type: "date", nullable: false),
                    pte_date_fin = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projet_techno", x => x.pte_id);
                    table.ForeignKey(
                        name: "FK_projet_techno_projet_prj_id",
                        column: x => x.prj_id,
                        principalTable: "projet",
                        principalColumn: "prj_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_projet_techno_version_techno_vte_id",
                        column: x => x.vte_id,
                        principalTable: "version_techno",
                        principalColumn: "vte_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personne_pst_code",
                table: "personne",
                column: "pst_code");

            migrationBuilder.CreateIndex(
                name: "IX_personne_techno_prs_id",
                table: "personne_techno",
                column: "prs_id");

            migrationBuilder.CreateIndex(
                name: "IX_personne_techno_vte_id",
                table: "personne_techno",
                column: "vte_id");

            migrationBuilder.CreateIndex(
                name: "IX_projet_personne_prj_id",
                table: "projet_personne",
                column: "prj_id");

            migrationBuilder.CreateIndex(
                name: "IX_projet_personne_prs_id",
                table: "projet_personne",
                column: "prs_id");

            migrationBuilder.CreateIndex(
                name: "IX_projet_personne_rlp_code",
                table: "projet_personne",
                column: "rlp_code");

            migrationBuilder.CreateIndex(
                name: "IX_projet_techno_prj_id",
                table: "projet_techno",
                column: "prj_id");

            migrationBuilder.CreateIndex(
                name: "IX_projet_techno_vte_id",
                table: "projet_techno",
                column: "vte_id");

            migrationBuilder.AddForeignKey(
                name: "FK_personne_poste_pst_code",
                table: "personne",
                column: "pst_code",
                principalTable: "poste",
                principalColumn: "pst_code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personne_poste_pst_code",
                table: "personne");

            migrationBuilder.DropTable(
                name: "personne_techno");

            migrationBuilder.DropTable(
                name: "projet_personne");

            migrationBuilder.DropTable(
                name: "projet_techno");

            migrationBuilder.DropIndex(
                name: "IX_personne_pst_code",
                table: "personne");

            migrationBuilder.DropColumn(
                name: "pst_code",
                table: "personne");
        }
    }
}
