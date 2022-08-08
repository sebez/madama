namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Client commanditaire d'un projet.
/// </summary>
public class Client
{
    /// <summary>
    /// Id technique du client.
    /// </summary>
    public ClientId Id { get; set; }

    /// <summary>
    /// Nom du Client.
    /// </summary>
    public string NomClient { get; set; }
}

/// <summary>
/// Id technique d'un Client.
/// </summary>
/// <param name="Id">ID.</param>
public record ClientId(string Id);
