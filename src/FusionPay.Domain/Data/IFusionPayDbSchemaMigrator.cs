using System.Threading.Tasks;

namespace FusionPay.Data;

public interface IFusionPayDbSchemaMigrator
{
    Task MigrateAsync();
}
