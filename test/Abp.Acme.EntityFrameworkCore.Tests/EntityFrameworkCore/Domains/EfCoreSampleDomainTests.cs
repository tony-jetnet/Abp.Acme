using Abp.Acme.Samples;
using Xunit;

namespace Abp.Acme.EntityFrameworkCore.Domains;

[Collection(AcmeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AcmeEntityFrameworkCoreTestModule>
{

}
