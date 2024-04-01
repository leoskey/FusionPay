using FusionPay.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FusionPay.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FusionPayController : AbpControllerBase
{
    protected FusionPayController()
    {
        LocalizationResource = typeof(FusionPayResource);
    }
}
