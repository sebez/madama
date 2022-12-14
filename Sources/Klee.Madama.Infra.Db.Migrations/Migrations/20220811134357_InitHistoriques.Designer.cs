// <auto-generated />
using System;
using Klee.Madama.Infra.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Klee.Madama.Infra.Db.Migrations.Migrations
{
    [DbContext(typeof(MadamaDbContext))]
    [Migration("20220811134357_InitHistoriques")]
    partial class InitHistoriques
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.CategorieTechno", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("cte_code");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("cte_libelle");

                    b.HasKey("Code");

                    b.ToTable("categorie_techno");

                    b.HasData(
                        new
                        {
                            Code = "FRONT",
                            Libelle = "Front"
                        },
                        new
                        {
                            Code = "BACK",
                            Libelle = "Back"
                        },
                        new
                        {
                            Code = "INFRA",
                            Libelle = "Infra"
                        },
                        new
                        {
                            Code = "CICD",
                            Libelle = "CI/CD"
                        });
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.Client", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("clt_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("clt_nom");

                    b.HasKey("Id");

                    b.ToTable("client");
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.Personne", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("prs_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Courriel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("prs_courriel");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("prs_nom");

                    b.Property<string>("PosteCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("pst_code");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("prs_prenom");

                    b.HasKey("Id");

                    b.HasIndex("PosteCode");

                    b.ToTable("personne");
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.PersonneTechno", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("prt_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateDebut")
                        .IsRequired()
                        .HasColumnType("date")
                        .HasColumnName("prt_date_debut");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("date")
                        .HasColumnName("prt_date_fin");

                    b.Property<int?>("PersonneId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("prs_id");

                    b.Property<int?>("VersionTechnoId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("vte_id");

                    b.HasKey("Id");

                    b.HasIndex("PersonneId");

                    b.HasIndex("VersionTechnoId");

                    b.ToTable("personne_techno");
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.Poste", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("pst_code");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("pst_libelle");

                    b.HasKey("Code");

                    b.ToTable("poste");

                    b.HasData(
                        new
                        {
                            Code = "LEAD_TECH",
                            Libelle = "Leader technique"
                        },
                        new
                        {
                            Code = "ARCHI",
                            Libelle = "Architecte"
                        },
                        new
                        {
                            Code = "DEV",
                            Libelle = "Développeur·se"
                        },
                        new
                        {
                            Code = "CHEF_PRJ",
                            Libelle = "Chef·fe de projet"
                        });
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.Projet", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("prj_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("ClientId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("clt_id");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("prj_nom");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("projet");
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.ProjetPersonne", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("pps_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateDebut")
                        .IsRequired()
                        .HasColumnType("date")
                        .HasColumnName("pps_date_debut");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("date")
                        .HasColumnName("pps_date_fin");

                    b.Property<int?>("PersonneId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("prs_id");

                    b.Property<int?>("ProjetId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("prj_id");

                    b.Property<string>("RoleProjetCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("rlp_code");

                    b.HasKey("Id");

                    b.HasIndex("PersonneId");

                    b.HasIndex("ProjetId");

                    b.HasIndex("RoleProjetCode");

                    b.ToTable("projet_personne");
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.ProjetTechno", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("pte_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateDebut")
                        .IsRequired()
                        .HasColumnType("date")
                        .HasColumnName("pte_date_debut");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("date")
                        .HasColumnName("pte_date_fin");

                    b.Property<int?>("ProjetId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("prj_id");

                    b.Property<int?>("VersionTechnoId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("vte_id");

                    b.HasKey("Id");

                    b.HasIndex("ProjetId");

                    b.HasIndex("VersionTechnoId");

                    b.ToTable("projet_techno");
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.RoleProjet", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("rlp_code");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("rlp_libelle");

                    b.HasKey("Code");

                    b.ToTable("role_projet");

                    b.HasData(
                        new
                        {
                            Code = "REF_TECH",
                            Libelle = "Référent technique"
                        },
                        new
                        {
                            Code = "REF_FONC",
                            Libelle = "Référent fonctionnel"
                        },
                        new
                        {
                            Code = "ARCHI",
                            Libelle = "Architecte"
                        },
                        new
                        {
                            Code = "DEV",
                            Libelle = "Développeur·se"
                        },
                        new
                        {
                            Code = "CHEF_PRJ",
                            Libelle = "Chef·fe de projet"
                        },
                        new
                        {
                            Code = "SCRUM_MST",
                            Libelle = "Scrum master"
                        });
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.Techno", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tec_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("CategorieTechnoCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("cte_code");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("tec_nom");

                    b.HasKey("Id");

                    b.HasIndex("CategorieTechnoCode");

                    b.ToTable("techno");
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.VersionTechno", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("vte_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("vte_nom");

                    b.Property<int?>("TechnoId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("tec_id");

                    b.HasKey("Id");

                    b.HasIndex("TechnoId");

                    b.ToTable("version_techno");
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.Personne", b =>
                {
                    b.HasOne("Klee.Madama.Infra.Db.Models.Poste", null)
                        .WithMany()
                        .HasForeignKey("PosteCode")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.PersonneTechno", b =>
                {
                    b.HasOne("Klee.Madama.Infra.Db.Models.Personne", null)
                        .WithMany()
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Klee.Madama.Infra.Db.Models.VersionTechno", null)
                        .WithMany()
                        .HasForeignKey("VersionTechnoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.Projet", b =>
                {
                    b.HasOne("Klee.Madama.Infra.Db.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.ProjetPersonne", b =>
                {
                    b.HasOne("Klee.Madama.Infra.Db.Models.Personne", null)
                        .WithMany()
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Klee.Madama.Infra.Db.Models.Projet", null)
                        .WithMany()
                        .HasForeignKey("ProjetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Klee.Madama.Infra.Db.Models.RoleProjet", null)
                        .WithMany()
                        .HasForeignKey("RoleProjetCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.ProjetTechno", b =>
                {
                    b.HasOne("Klee.Madama.Infra.Db.Models.Projet", null)
                        .WithMany()
                        .HasForeignKey("ProjetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Klee.Madama.Infra.Db.Models.VersionTechno", null)
                        .WithMany()
                        .HasForeignKey("VersionTechnoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.Techno", b =>
                {
                    b.HasOne("Klee.Madama.Infra.Db.Models.CategorieTechno", null)
                        .WithMany()
                        .HasForeignKey("CategorieTechnoCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Klee.Madama.Infra.Db.Models.VersionTechno", b =>
                {
                    b.HasOne("Klee.Madama.Infra.Db.Models.Techno", null)
                        .WithMany()
                        .HasForeignKey("TechnoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
