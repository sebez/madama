////
//// ATTENTION CE FICHIER EST GENERE AUTOMATIQUEMENT !
////

using Klee.Madama.Infra.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Klee.Madama.Infra.Db;

/// <summary>
/// DbContext généré pour Entity Framework Core.
/// </summary>
public partial class MadamaDbContext : DbContext
{
    /// <summary>
    /// Constructeur par défaut.
    /// </summary>
    /// <param name="options">Options du DbContext.</param>
    public MadamaDbContext(DbContextOptions<MadamaDbContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Accès à l'entité CategorieTechno.
    /// </summary>
    public DbSet<CategorieTechno> CategorieTechnos { get; set; }

    /// <summary>
    /// Accès à l'entité Client.
    /// </summary>
    public DbSet<Client> Clients { get; set; }

    /// <summary>
    /// Accès à l'entité Personne.
    /// </summary>
    public DbSet<Personne> Personnes { get; set; }

    /// <summary>
    /// Accès à l'entité Poste.
    /// </summary>
    public DbSet<Poste> Postes { get; set; }

    /// <summary>
    /// Accès à l'entité Projet.
    /// </summary>
    public DbSet<Projet> Projets { get; set; }

    /// <summary>
    /// Accès à l'entité RoleProjet.
    /// </summary>
    public DbSet<RoleProjet> RoleProjets { get; set; }

    /// <summary>
    /// Accès à l'entité Techno.
    /// </summary>
    public DbSet<Techno> Technos { get; set; }

    /// <summary>
    /// Accès à l'entité VersionTechno.
    /// </summary>
    public DbSet<VersionTechno> VersionTechnos { get; set; }

    /// <summary>
    /// Personalisation du modèle.
    /// </summary>
    /// <param name="modelBuilder">L'objet de construction du modèle.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Projet>().HasOne<Client>().WithMany().HasForeignKey(p => p.ClientId).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Techno>().HasOne<CategorieTechno>().WithMany().HasForeignKey(p => p.CategorieTechnoCode).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<VersionTechno>().HasOne<Techno>().WithMany().HasForeignKey(p => p.TechnoId).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<CategorieTechno>().HasData(
            new CategorieTechno { Code = "FRONT", Libelle = "Front" },
            new CategorieTechno { Code = "BACK", Libelle = "Back" },
            new CategorieTechno { Code = "INFRA", Libelle = "Infra" },
            new CategorieTechno { Code = "CICD", Libelle = "CI/CD" });
        modelBuilder.Entity<Poste>().HasData(
            new Poste { Code = "LEAD_TECH", Libelle = "Leader technique" },
            new Poste { Code = "ARCHI", Libelle = "Architecte" },
            new Poste { Code = "DEV", Libelle = "Développeur·se" },
            new Poste { Code = "CHEF_PRJ", Libelle = "Chef·fe de projet" });
        modelBuilder.Entity<RoleProjet>().HasData(
            new RoleProjet { Code = "REF_TECH", Libelle = "Référent technique" },
            new RoleProjet { Code = "REF_FONC", Libelle = "Référent fonctionnel" },
            new RoleProjet { Code = "ARCHI", Libelle = "Architecte" },
            new RoleProjet { Code = "DEV", Libelle = "Développeur·se" },
            new RoleProjet { Code = "CHEF_PRJ", Libelle = "Chef·fe de projet" },
            new RoleProjet { Code = "SCRUM_MST", Libelle = "Scrum master" });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
