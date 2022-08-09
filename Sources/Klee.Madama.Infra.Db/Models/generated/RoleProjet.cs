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
/// Rôle d'une personne dans une équipe projet.
/// </summary>
[DefaultProperty(nameof(Libelle))]
[Table("role_projet")]
public partial class RoleProjet
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
    /// Référent fonctionnel.
    /// </summary>
    public const string RefFonc = "REF_FONC";

    /// <summary>
    /// Référent technique.
    /// </summary>
    public const string RefTech = "REF_TECH";

    /// <summary>
    /// Scrum master.
    /// </summary>
    public const string Scrum = "SCRUM_MST";

    /// <summary>
    /// Constructeur.
    /// </summary>
    public RoleProjet()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public RoleProjet(RoleProjet bean)
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
    [Column("rlp_code")]
    [Domain(Domains.Code10)]
    [StringLength(10)]
    [Key]
    public string Code { get; set; }

    /// <summary>
    /// Libellé du rôle.
    /// </summary>
    [Column("rlp_libelle")]
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
    partial void OnCreated(RoleProjet bean);
}
