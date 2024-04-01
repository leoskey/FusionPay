using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FusionPay.Data;

/* This is used if database provider does't define
 * IFusionPayDbSchemaMigrator implementation.
 */
public class NullFusionPayDbSchemaMigrator : IFusionPayDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
