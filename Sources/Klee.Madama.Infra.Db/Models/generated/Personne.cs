////
//// ATTENTION CE FICHIER EST GENERE AUTOMATIQUEMENT !
////

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kinetix.Modeling.Annotations;
using Madama.Common;

namespace Klee.Madama.Infra.Db.Models;

/// <summary>
/// Personne travaillant dans l'entreprise.
/// </summary>
[Table("personne")]
public partial class Personne
{
    /// <summary>
    /// Constructeur.
    /// </summary>
    public Personne()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public Personne(Personne bean)
    {
        if (bean == null)
        {
            throw new ArgumentNullException(nameof(bean));
        }

        Id = bean.Id;
        Nom = bean.Nom;
        Prenom = bean.Prenom;
        Courriel = bean.Courriel;

        OnCreated(bean);
    }

    /// <summary>
    /// Id client.
    /// </summary>
    [Column("prs_id")]
    [Domain(Domains.Id)]
    [Key]
    public int? Id { get; set; }

    /// <summary>
    /// Nom de la personne.
    /// </summary>
    [Column("prs_nom")]
    [Required]
    [Domain(Domains.Libelle)]
    [StringLength(100)]
    public string Nom { get; set; }

    /// <summary>
    /// Prénom de la personne.
    /// </summary>
    [Column("prs_prenom")]
    [Required]
    [Domain(Domains.Libelle)]
    [StringLength(100)]
    public string Prenom { get; set; }

    /// <summary>
    /// Courriel de la personne.
    /// </summary>
    [Column("prs_courriel")]
    [Required]
    [Domain(Domains.Email)]
    [StringLength(100)]
    public string Courriel { get; set; }

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs.
    /// </summary>
    partial void OnCreated();

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    partial void OnCreated(Personne bean);
}
