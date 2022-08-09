namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Identité d'une personne.
/// </summary>
public struct Identite
{
    /// <summary>
    /// Prénom de la personne.
    /// </summary>
    public string Prenom { get; set; }

    /// <summary>
    /// Nom de la personne.
    /// </summary>
    public string Nom { get; set; }
}
