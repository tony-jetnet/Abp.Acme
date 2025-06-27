using Abp.Acme.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Acme.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AcmeController : AbpControllerBase
{
    protected AcmeController()
    {
        LocalizationResource = typeof(AcmeResource);
    }
}
