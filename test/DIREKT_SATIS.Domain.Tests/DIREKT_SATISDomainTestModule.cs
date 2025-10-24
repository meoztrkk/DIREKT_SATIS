using Volo.Abp.Modularity;

namespace DIREKT_SATIS;

[DependsOn(
    typeof(DIREKT_SATISDomainModule),
    typeof(DIREKT_SATISTestBaseModule)
)]
public class DIREKT_SATISDomainTestModule : AbpModule
{

}
