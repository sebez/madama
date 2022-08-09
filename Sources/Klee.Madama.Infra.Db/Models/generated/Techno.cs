////
//// ATTENTION CE FICHIER EST GENERE AUTOMATIQUEMENT !
////

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kinetix.Modeling.Annotations;
using Madama.Common;

namespace Klee.Madama.Infra.Db.Models;

/// <summary>
/// Technologie utilisée sur un projet.
/// </summary>
[Table("techno")]
public partial class Techno
{
    /// <summary>
    /// Constructeur.
    /// </summary>
    public Techno()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public Techno(Techno bean)
    {
        if (bean == null)
        {
            throw new ArgumentNullException(nameof(bean));
        }

        Id = bean.Id;
        Nom = bean.Nom;
        CategorieTechnoCode = bean.CategorieTechnoCode;

        OnCreated(bean);
    }

    /// <summary>
    /// Id techno.
    /// </summary>
    [Column("tec_id")]
    [Domain(Domains.Id)]
    [Key]
    public int? Id { get; set; }

    /// <summary>
    /// Nom de la techno.
    /// </summary>
    [Column("tec_nom")]
    [Required]
    [Domain(Domains.Libelle)]
    [StringLength(100)]
    public string Nom { get; set; }

    /// <summary>
    /// Catégorie de la techno.
    /// </summary>
    [Column("cte_code")]
    [Required]
    [ReferencedType(typeof(CategorieTechno))]
    [Domain(Domains.Code10)]
    [StringLength(10)]
    public string CategorieTechnoCode { get; set; }

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs.
    /// </summary>
    partial void OnCreated();

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    partial void OnCreated(Techno bean);
}
