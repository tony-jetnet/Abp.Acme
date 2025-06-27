using Volo.Abp.Modularity;

namespace Abp.Acme;

[DependsOn(
    typeof(AcmeDomainModule),
    typeof(AcmeTestBaseModule)
)]
public class AcmeDomainTestModule : AbpModule
{

}
