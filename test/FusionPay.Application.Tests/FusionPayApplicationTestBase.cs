using Volo.Abp.Modularity;

namespace FusionPay;

public abstract class FusionPayApplicationTestBase<TStartupModule> : FusionPayTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
