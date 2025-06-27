using Microsoft.Extensions.Localization;
using Abp.Acme.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.Acme;

[Dependency(ReplaceServices = true)]
public class AcmeBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AcmeResource> _localizer;

    public AcmeBrandingProvider(IStringLocalizer<AcmeResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
