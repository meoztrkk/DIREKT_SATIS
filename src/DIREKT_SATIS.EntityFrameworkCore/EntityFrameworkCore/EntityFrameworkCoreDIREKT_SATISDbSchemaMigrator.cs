using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DIREKT_SATIS.Data;
using Volo.Abp.DependencyInjection;

namespace DIREKT_SATIS.EntityFrameworkCore;

public class EntityFrameworkCoreDIREKT_SATISDbSchemaMigrator
    : IDIREKT_SATISDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDIREKT_SATISDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DIREKT_SATISDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DIREKT_SATISDbContext>()
            .Database
            .MigrateAsync();
    }
}
