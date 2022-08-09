////
//// ATTENTION CE FICHIER EST GENERE AUTOMATIQUEMENT !
////

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kinetix.Modeling.Annotations;
using Madama.Common;

namespace Klee.Madama.Infra.Db.Models;

/// <summary>
/// Version d'une technologie.
/// </summary>
[Table("version_techno")]
public partial class VersionTechno
{
    /// <summary>
    /// Constructeur.
    /// </summary>
    public VersionTechno()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public VersionTechno(VersionTechno bean)
    {
        if (bean == null)
        {
            throw new ArgumentNullException(nameof(bean));
        }

        Id = bean.Id;
        Nom = bean.Nom;
        TechnoId = bean.TechnoId;

        OnCreated(bean);
    }

    /// <summary>
    /// Id version techno.
    /// </summary>
    [Column("vte_id")]
    [Domain(Domains.Id)]
    [Key]
    public int? Id { get; set; }

    /// <summary>
    /// Nom de la version.
    /// </summary>
    [Column("vte_nom")]
    [Required]
    [Domain(Domains.Libelle)]
    [StringLength(100)]
    public string Nom { get; set; }

    /// <summary>
    /// Techno dont c'est une version.
    /// </summary>
    [Column("tec_id")]
    [Required]
    [ReferencedType(typeof(Techno))]
    [Domain(Domains.Id)]
    public int? TechnoId { get; set; }

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs.
    /// </summary>
    partial void OnCreated();

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    partial void OnCreated(VersionTechno bean);
}
