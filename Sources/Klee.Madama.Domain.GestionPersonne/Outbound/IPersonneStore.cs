using Klee.Madama.Domain.GestionPersonne.Model;

namespace Klee.Madama.Domain.GestionPersonne.Outbound;

/// <summary>
/// Contrat du store d'une personne.
/// </summary>
public interface IPersonneStore
{
    /// <summary>
    /// Charge une personne.
    /// </summary>
    /// <param name="personneId">ID.</param>
    /// <returns>Personne.</returns>
    Task<Personne> GetPersonne(PersonneId personneId);
}
