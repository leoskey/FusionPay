using FusionPay.Localization;
using Volo.Abp.Application.Services;

namespace FusionPay;

/* Inherit your application services from this class.
 */
public abstract class FusionPayAppService : ApplicationService
{
    protected FusionPayAppService()
    {
        LocalizationResource = typeof(FusionPayResource);
    }
}
