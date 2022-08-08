namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Expérience d'une personne avec un rôle donné, sur un projet donné, sur une période donnée.
/// </summary>
public class ExperiencePersonne
{
    /// <summary>
    /// Role de la personne pendant l'expérience.
    /// </summary>
    public Role Role { get; set; }

    /// <summary>
    /// Période d'exercice de l'expérience.
    /// </summary>
    public Periode Periode { get; set; }

    /// <summary>
    /// Projet sur lequel la personne est intervenue.
    /// </summary>
    public Projet Projet { get; set; }
}
