namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Une personne travaillant dans l'entreprise.
/// Une personne a un historique de poste, un historique de travail sur des projets, et sur des technos.
/// </summary>
public class Personne
{
    /// <summary>
    /// Id technique du poste.
    /// </summary>
    public PersonneId Id { get; set; }

    /// <summary>
    /// Identité.
    /// </summary>
    public Identite Identite { get; set; }

    /// <summary>
    /// Poste actuel de la personne.
    /// </summary>
    public PostePersonne PosteActuel { get; set; }

    /// <summary>
    /// Historique d'expériences de la personne.
    /// </summary>
    public List<ExperiencePersonne> HistoriqueExperience { get; set; } = new();

    /// <summary>
    /// Historique de postes de la personne.
    /// </summary>
    public List<PostePersonne> HistoriquePoste { get; set; } = new();

    /// <summary>
    /// Historique de technos de la personne.
    /// </summary>
    public List<TechnoPersonne> HistoriqueTechno { get; set; } = new();
}

/// <summary>
/// Id technique d'une personne.
/// </summary>
/// <param name="Id">ID.</param>
public record PersonneId(string Id);
