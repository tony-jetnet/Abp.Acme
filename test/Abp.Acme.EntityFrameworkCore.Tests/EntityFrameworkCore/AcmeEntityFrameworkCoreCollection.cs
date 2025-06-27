using Xunit;

namespace Abp.Acme.EntityFrameworkCore;

[CollectionDefinition(AcmeTestConsts.CollectionDefinitionName)]
public class AcmeEntityFrameworkCoreCollection : ICollectionFixture<AcmeEntityFrameworkCoreFixture>
{

}
