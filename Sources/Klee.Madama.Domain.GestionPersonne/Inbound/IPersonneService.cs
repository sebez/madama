using Klee.Madama.Domain.GestionPersonne.Model;

namespace Klee.Madama.Domain.GestionPersonne.Inbound;

/// <summary>
/// Contrat du service des personnes.
/// </summary>
public interface IPersonneService
{
    /// <summary>
    /// Charge une personne.
    /// </summary>
    /// <param name="personneId">ID de la personne.</param>
    /// <returns>Personne.</returns>
    Task<Personne> GetPersonne(PersonneId personneId);
}
