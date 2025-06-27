using Volo.Abp.Modularity;

namespace Abp.Acme;

public abstract class AcmeApplicationTestBase<TStartupModule> : AcmeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
