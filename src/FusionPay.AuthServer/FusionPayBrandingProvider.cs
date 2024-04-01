using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FusionPay;

[Dependency(ReplaceServices = true)]
public class FusionPayBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "FusionPay";
}
