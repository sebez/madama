namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Version d'une techno.
/// </summary>
public class VersionTechno
{
    /// <summary>
    /// Id technique de la VersionTechno.
    /// </summary>
    public VersionTechnoId Id { get; set; }

    /// <summary>
    /// Nom de la version.
    /// </summary>
    public string NomVersionTechno { get; set; }

    /// <summary>
    /// Techno dont c'est une version.
    /// </summary>
    public Techno Techno { get; set; }
}

/// <summary>
/// Id technique d'un VersionTechno.
/// </summary>
/// <param name="Id">ID.</param>
public record VersionTechnoId(string Id);
