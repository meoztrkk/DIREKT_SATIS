using DIREKT_SATIS.Books;
using Xunit;

namespace DIREKT_SATIS.EntityFrameworkCore.Applications.Books;

[Collection(DIREKT_SATISTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<DIREKT_SATISEntityFrameworkCoreTestModule>
{

}