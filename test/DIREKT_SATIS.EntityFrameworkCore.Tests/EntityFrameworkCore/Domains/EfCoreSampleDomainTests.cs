using DIREKT_SATIS.Samples;
using Xunit;

namespace DIREKT_SATIS.EntityFrameworkCore.Domains;

[Collection(DIREKT_SATISTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DIREKT_SATISEntityFrameworkCoreTestModule>
{

}
