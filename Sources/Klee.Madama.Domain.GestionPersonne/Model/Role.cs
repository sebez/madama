namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Role d'une personne dans le contexte d'un projet.
/// </summary>
public class Role
{
    /// <summary>
    /// Id technique du Role.
    /// </summary>
    public RoleId Id { get; set; }

    /// <summary>
    /// Nom du Role.
    /// </summary>
    public string Nom { get; set; }
}

/// <summary>
/// Id technique d'un Role.
/// </summary>
/// <param name="Id">ID.</param>
public record RoleId(string Id);
