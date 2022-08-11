////
//// ATTENTION CE FICHIER EST GENERE AUTOMATIQUEMENT !
////

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Kinetix.Modeling.Annotations;
using Madama.Common;

namespace Klee.Madama.Infra.Db.Models;

/// <summary>
/// Lien projet personne.
/// </summary>
[Table("projet_personne")]
public partial class ProjetPersonne
{
    /// <summary>
    /// Constructeur.
    /// </summary>
    public ProjetPersonne()
    {
        OnCreated();
    }

    /// <summary>
    /// Constructeur par recopie.
    /// </summary>
    /// <param name="bean">Source.</param>
    public ProjetPersonne(ProjetPersonne bean)
    {
        if (bean == null)
        {
            throw new ArgumentNullException(nameof(bean));
        }

        Id = bean.Id;
        ProjetId = bean.ProjetId;
        PersonneId = bean.PersonneId;
        RoleProjetCode = bean.RoleProjetCode;
        DateDebut = bean.DateDebut;
        DateFin = bean.DateFin;

        OnCreated(bean);
    }

    /// <summary>
    /// Id lien.
    /// </summary>
    [Column("pps_id")]
    [Domain(Domains.Id)]
    [Key]
    public int? Id { get; set; }

    /// <summary>
    /// Projet.
    /// </summary>
    [Column("prj_id")]
    [Required]
    [ReferencedType(typeof(Projet))]
    [Domain(Domains.Id)]
    public int? ProjetId { get; set; }

    /// <summary>
    /// Personne.
    /// </summary>
    [Column("prs_id")]
    [Required]
    [ReferencedType(typeof(Personne))]
    [Domain(Domains.Id)]
    public int? PersonneId { get; set; }

    /// <summary>
    /// Rôle.
    /// </summary>
    [Column("rlp_code")]
    [Required]
    [ReferencedType(typeof(RoleProjet))]
    [Domain(Domains.Code10)]
    [StringLength(10)]
    public string RoleProjetCode { get; set; }

    /// <summary>
    /// Date de début de la participation de la personne au projet.
    /// </summary>
    [Column("pps_date_debut", TypeName = "date")]
    [Required]
    [Domain(Domains.Date)]
    public DateTime? DateDebut { get; set; }

    /// <summary>
    /// Date de fin de la participation de la personne au projet.
    /// </summary>
    [Column("pps_date_fin", TypeName = "date")]
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
    partial void OnCreated(ProjetPersonne bean);
}
