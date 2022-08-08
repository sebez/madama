namespace Klee.Madama.Domain.GestionPersonne.Model;

/// <summary>
/// Période d'une expérience.
/// </summary>
public class Periode
{
    /// <summary>
    /// Début de la période.
    /// </summary>
    public DateOnly Debut { get; set; }

    /// <summary>
    /// Fin de la période.
    /// </summary>
    public DateOnly? Fin { get; set; }
}
