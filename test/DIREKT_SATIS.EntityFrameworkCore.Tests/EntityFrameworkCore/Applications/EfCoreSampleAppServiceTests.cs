using DIREKT_SATIS.Samples;
using Xunit;

namespace DIREKT_SATIS.EntityFrameworkCore.Applications;

[Collection(DIREKT_SATISTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DIREKT_SATISEntityFrameworkCoreTestModule>
{

}
