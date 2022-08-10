using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Klee.Madama.Infra.Db.Migrations;

/// <summary>
/// Provide a DbContext factory for dotnet ef commands.
/// </summary>
public class MadamaDbContextFactory : IDesignTimeDbContextFactory<MadamaDbContext>
{
    /// <inheritdoc cref="IDesignTimeDbContextFactory{TContext}.CreateDbContext" />
    public MadamaDbContext CreateDbContext(string[] args)
    {
        var config = ConfigBuilder.GetConfig();

        var connectionString = config.DbConnectionString();

        return new MadamaDbContext(
            new DbContextOptionsBuilder<MadamaDbContext>()
            .UseSqlServer(connectionString, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName))
            .Options);
    }
}
