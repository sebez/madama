using System.Runtime.InteropServices;
using Microsoft.Extensions.Configuration;

namespace Klee.Madama.Infra.Db.Migrations;

/// <summary>
/// Config builder.
/// </summary>
public class ConfigBuilder
{
    /// <summary>
    /// Récupère la config du fichier de config.
    /// </summary>
    /// <returns>Config.</returns>
    public static IConfigurationRoot GetConfig()
    {
        /* In CI/CD, environement variable is used. */
        var configManager = new ConfigurationManager().AddEnvironmentVariables(prefix: "Madama_");
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            /* On dev machine, appsettings.json file is used. */
            configManager.AddJsonFile($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Madama/dbsettings.json", optional: true);
        }
        return configManager.Build();
    }
}
