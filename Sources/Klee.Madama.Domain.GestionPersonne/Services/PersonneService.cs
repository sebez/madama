using Klee.Madama.Domain.GestionPersonne.Inbound;
using Klee.Madama.Domain.GestionPersonne.Model;
using Klee.Madama.Domain.GestionPersonne.Outbound;

namespace Klee.Madama.Domain.GestionPersonne.Services;

/// <summary>
/// Je consulte une personne de l'annuaire.
/// </summary>
public class PersonneService : IPersonneService
{
    private readonly IPersonneStore _personneStore;

    /// <summary>
    /// Constructeur.
    /// </summary>
    public PersonneService(IPersonneStore personneStore)
    {
        _personneStore = personneStore;
    }

    /// <summary>
    /// Consulter une personne.
    /// </summary>
    /// <param name="personneId">ID de la personne.</param>
    /// <returns>Personne.</returns>
    public Task<Personne> GetPersonne(PersonneId personneId)
    {
        return _personneStore.GetPersonne(personneId);
    }
}
