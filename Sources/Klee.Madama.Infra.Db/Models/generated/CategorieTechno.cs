////
//// ATTENTION CE FICHIER EST GENERE AUTOMATIQUEMENT !
////

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kinetix.Modeling.Annotations;
using Madama.Common;

namespace Klee.Madama.Infra.Db.Models;

/// <summary>
/// Catégorie d'une techno.
/// </summary>
[DefaultProperty(nameof(Libelle))]
[Table("categorie_techno")]
public partial class CategorieTechno
{
    /// <summary>
    /// Back.
    /// </summary>
    public const string Back = "BACK";

    /// <summary>
    /// CI/CD.
    /// </summary>
    public const string CICD = "CICD";

    /// <summary>
    /// Front.
    /// </summary>
    public const string Front = "FRONT";

    /// <summary>
    /// Infra.
    /// </summary>
    public const string Infra = "INFRA";

    /// <summary>
    /// Constructeur.
    /// </summary>
    public CategorieTechno()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public CategorieTechno(CategorieTechno bean)
    {
        if (bean == null)
        {
            throw new ArgumentNullException(nameof(bean));
        }

        Code = bean.Code;
        Libelle = bean.Libelle;

        OnCreated(bean);
    }

    /// <summary>
    /// Code catégorie techno.
    /// </summary>
    [Column("cte_code")]
    [Domain(Domains.Code10)]
    [StringLength(10)]
    [Key]
    public string Code { get; set; }

    /// <summary>
    /// Libellé de la catégorie techno.
    /// </summary>
    [Column("cte_libelle")]
    [Required]
    [Domain(Domains.Libelle)]
    [StringLength(100)]
    public string Libelle { get; set; }

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs.
    /// </summary>
    partial void OnCreated();

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    partial void OnCreated(CategorieTechno bean);
}
