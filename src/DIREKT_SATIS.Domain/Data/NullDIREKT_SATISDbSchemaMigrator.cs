using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DIREKT_SATIS.Data;

/* This is used if database provider does't define
 * IDIREKT_SATISDbSchemaMigrator implementation.
 */
public class NullDIREKT_SATISDbSchemaMigrator : IDIREKT_SATISDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
