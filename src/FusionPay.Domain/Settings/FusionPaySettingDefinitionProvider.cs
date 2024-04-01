using Volo.Abp.Settings;

namespace FusionPay.Settings;

public class FusionPaySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FusionPaySettings.MySetting1));
    }
}
