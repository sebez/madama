namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Catégorie d'une techno (Front / Back / ...).
/// </summary>
public class CategorieTechno
{
    /// <summary>
    /// Id technique de la CategorieTechno.
    /// </summary>
    public CategorieTechnoId Id { get; set; }

    /// <summary>
    /// Nom de la CategorieTechno.
    /// </summary>
    public string NomCategorieTechno { get; set; }
}

/// <summary>
/// Id technique d'une CategorieTechno.
/// </summary>
/// <param name="Id">ID.</param>
public record CategorieTechnoId(string Id);
