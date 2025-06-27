using Volo.Abp.Modularity;

namespace Abp.Acme;

[DependsOn(
    typeof(AcmeApplicationModule),
    typeof(AcmeDomainTestModule)
)]
public class AcmeApplicationTestModule : AbpModule
{

}
