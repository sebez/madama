////
//// ATTENTION CE FICHIER EST GENERE AUTOMATIQUEMENT !
////

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kinetix.Modeling.Annotations;
using Madama.Common;

namespace Klee.Madama.Infra.Db.Models;

/// <summary>
/// Client de l'entreprise, commandaitaire de projets.
/// </summary>
[Table("client")]
public partial class Client
{
    /// <summary>
    /// Constructeur.
    /// </summary>
    public Client()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public Client(Client bean)
    {
        if (bean == null)
        {
            throw new ArgumentNullException(nameof(bean));
        }

        Id = bean.Id;
        Nom = bean.Nom;

        OnCreated(bean);
    }

    /// <summary>
    /// Id client.
    /// </summary>
    [Column("clt_id")]
    [Domain(Domains.Id)]
    [Key]
    public int? Id { get; set; }

    /// <summary>
    /// Nom du client.
    /// </summary>
    [Column("clt_nom")]
    [Required]
    [Domain(Domains.Libelle)]
    [StringLength(100)]
    public string Nom { get; set; }

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs.
    /// </summary>
    partial void OnCreated();

    /// <summary>
    /// Methode d'extensibilité possible pour les constructeurs par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    partial void OnCreated(Client bean);
}
