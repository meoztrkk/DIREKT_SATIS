using Volo.Abp.Modularity;

namespace DIREKT_SATIS;

/* Inherit from this class for your domain layer tests. */
public abstract class DIREKT_SATISDomainTestBase<TStartupModule> : DIREKT_SATISTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
