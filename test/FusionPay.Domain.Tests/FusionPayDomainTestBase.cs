using Volo.Abp.Modularity;

namespace FusionPay;

/* Inherit from this class for your domain layer tests. */
public abstract class FusionPayDomainTestBase<TStartupModule> : FusionPayTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
