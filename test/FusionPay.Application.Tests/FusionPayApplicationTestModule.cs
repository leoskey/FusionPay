using Volo.Abp.Modularity;

namespace FusionPay;

[DependsOn(
    typeof(FusionPayApplicationModule),
    typeof(FusionPayDomainTestModule)
)]
public class FusionPayApplicationTestModule : AbpModule
{

}
