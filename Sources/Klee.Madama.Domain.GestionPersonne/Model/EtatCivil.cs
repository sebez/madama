namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Etat civil d'une personne.
/// </summary>
public struct EtatCivil
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
