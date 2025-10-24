using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DIREKT_SATIS.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class DIREKT_SATISDbContextFactory : IDesignTimeDbContextFactory<DIREKT_SATISDbContext>
{
    public DIREKT_SATISDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        DIREKT_SATISEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<DIREKT_SATISDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new DIREKT_SATISDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../DIREKT_SATIS.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
