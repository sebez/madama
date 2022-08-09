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
/// Poste d'une personne.
/// </summary>
[DefaultProperty(nameof(Libelle))]
[Table("poste")]
public partial class Poste
{
    /// <summary>
    /// Architecte.
    /// </summary>
    public const string Architecte = "ARCHI";

    /// <summary>
    /// Chef·fe de projet.
    /// </summary>
    public const string CP = "CHEF_PROJET";

    /// <summary>
    /// Développeur·se.
    /// </summary>
    public const string Dev = "DEV";

    /// <summary>
    /// Leader technique.
    /// </summary>
    public const string LeadTech = "LEAD_TECH";

    /// <summary>
    /// Constructeur.
    /// </summary>
    public Poste()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public Poste(Poste bean)
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
    /// Code poste.
    /// </summary>
    [Column("pst_code")]
    [Domain(Domains.Code10)]
    [StringLength(10)]
    [Key]
    public string Code { get; set; }

    /// <summary>
    /// Libellé du poste.
    /// </summary>
    [Column("pst_libelle")]
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
    partial void OnCreated(Poste bean);
}
