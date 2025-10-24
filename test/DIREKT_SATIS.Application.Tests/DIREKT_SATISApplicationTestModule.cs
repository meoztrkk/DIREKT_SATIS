using Volo.Abp.Modularity;

namespace DIREKT_SATIS;

[DependsOn(
    typeof(DIREKT_SATISApplicationModule),
    typeof(DIREKT_SATISDomainTestModule)
)]
public class DIREKT_SATISApplicationTestModule : AbpModule
{

}
