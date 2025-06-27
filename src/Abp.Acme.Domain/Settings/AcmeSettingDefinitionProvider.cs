using Volo.Abp.Settings;

namespace Abp.Acme.Settings;

public class AcmeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AcmeSettings.MySetting1));
    }
}
