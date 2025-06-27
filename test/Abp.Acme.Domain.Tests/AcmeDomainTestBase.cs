using Volo.Abp.Modularity;

namespace Abp.Acme;

/* Inherit from this class for your domain layer tests. */
public abstract class AcmeDomainTestBase<TStartupModule> : AcmeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
