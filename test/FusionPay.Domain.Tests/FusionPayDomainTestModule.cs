using Volo.Abp.Modularity;

namespace FusionPay;

[DependsOn(
    typeof(FusionPayDomainModule),
    typeof(FusionPayTestBaseModule)
)]
public class FusionPayDomainTestModule : AbpModule
{

}
