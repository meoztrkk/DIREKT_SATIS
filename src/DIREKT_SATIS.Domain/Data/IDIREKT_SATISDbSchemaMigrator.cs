using System.Threading.Tasks;

namespace DIREKT_SATIS.Data;

public interface IDIREKT_SATISDbSchemaMigrator
{
    Task MigrateAsync();
}
