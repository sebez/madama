namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Poste dans l'entreprise.
/// </summary>
public class Poste
{
    /// <summary>
    /// Id technique du poste.
    /// </summary>
    public PosteId Id { get; set; }

    /// <summary>
    /// Nom du poste.
    /// </summary>
    public string Nom { get; set; }
}

/// <summary>
/// Id technique d'un poste.
/// </summary>
/// <param name="Id">ID.</param>
public record PosteId(string Id);
