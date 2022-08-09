////
//// ATTENTION CE FICHIER EST GENERE AUTOMATIQUEMENT !
////

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kinetix.Modeling.Annotations;
using Madama.Common;

namespace Klee.Madama.Infra.Db.Models;

/// <summary>
/// Projet commandité par un client.
/// </summary>
[Table("projet")]
public partial class Projet
{
    /// <summary>
    /// Constructeur.
    /// </summary>
    public Projet()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public Projet(Projet bean)
    {
        if (bean == null)
        {
            throw new ArgumentNullException(nameof(bean));
        }

        Id = bean.Id;
        Nom = bean.Nom;
        ClientId = bean.ClientId;

        OnCreated(bean);
    }

    /// <summary>
    /// Id projet.
    /// </summary>
    [Column("prj_id")]
    [Domain(Domains.Id)]
    [Key]
    public int? Id { get; set; }

    /// <summary>
    /// Nom du projet.
    /// </summary>
    [Column("prj_nom")]
    [Required]
    [Domain(Domains.Libelle)]
    [StringLength(100)]
    public string Nom { get; set; }

    /// <summary>
    /// Client du projet.
    /// </summary>
    [Column("clt_id")]
    [Required]
    [ReferencedType(typeof(Client))]
    [Domain(Domains.Id)]
    public int? ClientId { get; set; }

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs.
    /// </summary>
    partial void OnCreated();

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    partial void OnCreated(Projet bean);
}
