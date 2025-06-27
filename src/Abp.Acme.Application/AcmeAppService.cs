using Abp.Acme.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Acme;

/* Inherit your application services from this class.
 */
public abstract class AcmeAppService : ApplicationService
{
    protected AcmeAppService()
    {
        LocalizationResource = typeof(AcmeResource);
    }
}
