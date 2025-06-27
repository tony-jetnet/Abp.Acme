using Abp.Acme.Books;
using Xunit;

namespace Abp.Acme.EntityFrameworkCore.Applications.Books;

[Collection(AcmeTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<AcmeEntityFrameworkCoreTestModule>
{

}