namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Techno utilisée par une personne sur une période donnée.
/// </summary>
public class TechnoPersonne
{
    /// <summary>
    /// Techno utilisée par la personne pendant la période.
    /// </summary>
    public Techno Techno { get; set; }

    /// <summary>
    /// Période d'usage de la techno.
    /// </summary>
    public Periode Periode { get; set; }
}
