using Microsoft.Extensions.Configuration;

namespace Klee.Madama.Infra.Db.Migrations;

/// <summary>
/// Configuration extensions.
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// DB connection string.
    /// </summary>
    /// <param name="source">Configuration.</param>
    /// <returns>Connection string.</returns>
    public static string DbConnectionString(this IConfiguration source)
    {
        return source["ConnectionStrings:BusinessDb"] ?? throw new NotSupportedException("Db connection string config is missing.");
    }
}
