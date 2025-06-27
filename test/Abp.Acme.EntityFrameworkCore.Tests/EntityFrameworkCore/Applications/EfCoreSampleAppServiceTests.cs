using Abp.Acme.Samples;
using Xunit;

namespace Abp.Acme.EntityFrameworkCore.Applications;

[Collection(AcmeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AcmeEntityFrameworkCoreTestModule>
{

}
