using Volo.Abp.Modularity;

namespace DIREKT_SATIS;

public abstract class DIREKT_SATISApplicationTestBase<TStartupModule> : DIREKT_SATISTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
