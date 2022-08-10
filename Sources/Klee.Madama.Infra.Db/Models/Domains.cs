using Kinetix.Modeling.Annotations;
using Kinetix.Reporting.Annotations;

namespace Madama.Common;

/// <summary>
/// Définit les domaines utilises par l'application.
/// </summary>
public enum Domains
{
    /// <summary>
    /// Domaine DO_BOOLEEN.
    /// </summary>
    [DomainType(typeof(bool?))]
    [BooleanFormat("Oui", "Non")]
    Booleen,

    /// <summary>
    /// Domaine DO_CODE_5.
    /// </summary>
    [DomainType(typeof(string))]
    Code5,

    /// <summary>
    /// Domaine DO_CODE_10.
    /// </summary>
    [DomainType(typeof(string))]
    Code10,

    /// <summary>
    /// Domaine DO_CODE_20.
    /// </summary>
    [DomainType(typeof(string))]
    Code20,

    /// <summary>
    /// Domaine DO_CODE_50.
    /// </summary>
    [DomainType(typeof(string))]
    Code50,

    /// <summary>
    /// Domaine DO_COMMENTAIRE.
    /// </summary>
    [DomainType(typeof(string))]
    Commentaire,

    /// <summary>
    /// Domaine DO_COMMENTAIRE2000.
    /// </summary>
    [DomainType(typeof(string))]
    Commentaire2000,

    /// <summary>
    /// Domaine DO_DATE.
    /// Format JJ/MM/AAAA.
    /// </summary>
    [DomainType(typeof(DateTime?))]
    [Date]
    [DateFormat("dd/MM/yyyy")]
    Date,

    /// <summary>
    /// Domaine DO_DATE_HEURE.
    /// Format JJ/MM/AAAA HH:MM.
    /// </summary>
    [DomainType(typeof(DateTime?))]
    [Date]
    [DateFormat("dd/MM/yyyy hh:mm:ss")]
    DateHeure,

    /// <summary>
    /// Domaine DO_EMAIL.
    /// </summary>
    [DomainType(typeof(string))]
    [Email(100)]
    Email,

    /// <summary>
    /// Domaine DO_ENTIER.
    /// </summary>
    [DomainType(typeof(int?))]
    Entier,

    /// <summary>
    /// Domaine DO_FLAG.
    /// </summary>
    [DomainType(typeof(int?))]
    Flag,

    /// <summary>
    /// Domaine DO_FLAGS.
    /// </summary>
    [DomainType(typeof(int?))]
    Flags,

    /// <summary>
    /// Domaine DO_GUID.
    /// </summary>
    [DomainType(typeof(Guid?))]
    Guid,

    /// <summary>
    /// Domaine DO_ID.
    /// </summary>
    [DomainType(typeof(int?))]
    Id,

    /// <summary>
    /// Domaine DO_LIBELLE.
    /// </summary>
    [DomainType(typeof(string))]
    Libelle,

    /// <summary>
    /// Domaine DO_LIBELLE.
    /// </summary>
    [DomainType(typeof(string))]
    LibelleCourt,

    /// <summary>
    /// Domaine DO_LIBELLE.
    /// </summary>
    [DomainType(typeof(string))]
    LibelleLong,

    /// <summary>
    /// Domaine DO_MONTANT.
    /// </summary>
    [DomainType(typeof(decimal?))]
    [NumberFormat("#,### €")]
    Montant,

    /// <summary>
    /// Domaine DO_MULTI_ENTIER.
    /// </summary>
    [DomainType(typeof(int[]))]
    MultiEntier,

    /// <summary>
    /// Domaine DO_MULTI_TEXTE.
    /// </summary>
    [DomainType(typeof(string[]))]
    MultiTexte,

    /// <summary>
    /// Domaine Siret.
    /// </summary>
    [DomainType(typeof(string))]
    Siret,

    /// <summary>
    /// Domaine DO_TEL.
    /// </summary>
    [DomainType(typeof(string))]
    Tel,

    /// <summary>
    /// Domaine Url.
    /// </summary>
    [DomainType(typeof(string))]
    Url,

    /// <summary>
    /// Domaine JSON.
    /// </summary>
    [DomainType(typeof(string))]
    Json,

    /// <summary>
    /// Domaine string.
    /// </summary>
    [DomainType(typeof(string))]
    String
}
