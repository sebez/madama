namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Poste d'une personne sur une période donnée.
/// </summary>
public class PostePersonne
{
    /// <summary>
    /// Poste de la personne pendant la période.
    /// </summary>
    public Poste Poste { get; set; }

    /// <summary>
    /// Période d'exercice du poste.
    /// </summary>
    public Periode Periode { get; set; }
}
