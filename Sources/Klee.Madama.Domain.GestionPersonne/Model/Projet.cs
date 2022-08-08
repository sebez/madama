namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Projet sur lequel une personne intervient.
/// </summary>
public class Projet
{
    /// <summary>
    /// Id technique du poste.
    /// </summary>
    public ProjetId Id { get; set; }

    /// <summary>
    /// Nom du projet.
    /// </summary>
    public string NomProjet { get; set; }

    /// <summary>
    /// Client commanditaire du projet.
    /// </summary>
    public Client Client { get; set; }
}

/// <summary>
/// Id technique d'un projet.
/// </summary>
/// <param name="Id">ID.</param>
public record ProjetId(string Id);
