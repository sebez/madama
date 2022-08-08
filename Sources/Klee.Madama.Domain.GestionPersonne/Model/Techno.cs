namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Techno au sens large.
/// </summary>
public class Techno
{
    /// <summary>
    /// Id technique de la Techno.
    /// </summary>
    public TechnoId Id { get; set; }

    /// <summary>
    /// Nom de la Techno.
    /// </summary>
    public string NomTechno { get; set; }

    /// <summary>
    /// Catégorie de la techno.
    /// </summary>
    public CategorieTechno Categorie { get; set; }
}

/// <summary>
/// Id technique d'une Techno.
/// </summary>
/// <param name="Id">ID.</param>
public record TechnoId(string Id);
