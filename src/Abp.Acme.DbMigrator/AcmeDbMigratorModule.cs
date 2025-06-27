using Abp.Acme.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Abp.Acme.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AcmeEntityFrameworkCoreModule),
    typeof(AcmeApplicationContractsModule)
)]
public class AcmeDbMigratorModule : AbpModule
{
}
