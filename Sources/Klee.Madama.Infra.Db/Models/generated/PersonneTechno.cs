////
//// ATTENTION CE FICHIER EST GENERE AUTOMATIQUEMENT !
////

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kinetix.Modeling.Annotations;
using Madama.Common;

namespace Klee.Madama.Infra.Db.Models;

/// <summary>
/// Lien projet techno.
/// </summary>
[Table("personne_techno")]
public partial class PersonneTechno
{
    /// <summary>
    /// Constructeur.
    /// </summary>
    public PersonneTechno()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public PersonneTechno(PersonneTechno bean)
    {
        if (bean == null)
        {
            throw new ArgumentNullException(nameof(bean));
        }

        Id = bean.Id;
        PersonneId = bean.PersonneId;
        VersionTechnoId = bean.VersionTechnoId;
        DateDebut = bean.DateDebut;
        DateFin = bean.DateFin;

        OnCreated(bean);
    }

    /// <summary>
    /// Id lien.
    /// </summary>
    [Column("prt_id")]
    [Domain(Domains.Id)]
    [Key]
    public int? Id { get; set; }

    /// <summary>
    /// Personne.
    /// </summary>
    [Column("prs_id")]
    [Required]
    [ReferencedType(typeof(Personne))]
    [Domain(Domains.Id)]
    public int? PersonneId { get; set; }

    /// <summary>
    /// Version techno.
    /// </summary>
    [Column("vte_id")]
    [Required]
    [ReferencedType(typeof(VersionTechno))]
    [Domain(Domains.Id)]
    public int? VersionTechnoId { get; set; }

    /// <summary>
    /// Date de début de l'usage de la techno par la personne.
    /// </summary>
    [Column("prt_date_debut", TypeName = "date")]
    [Required]
    [Domain(Domains.Date)]
    public DateTime? DateDebut { get; set; }

    /// <summary>
    /// Date de fin de l'usage de la techno par la personne.
    /// </summary>
    [Column("prt_date_fin", TypeName = "date")]
    [Domain(Domains.Date)]
    public DateTime? DateFin { get; set; }

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs.
    /// </summary>
    partial void OnCreated();

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    partial void OnCreated(PersonneTechno bean);
}
