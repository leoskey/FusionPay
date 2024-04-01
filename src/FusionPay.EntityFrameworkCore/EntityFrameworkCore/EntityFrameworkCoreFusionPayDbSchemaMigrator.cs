using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FusionPay.Data;
using Volo.Abp.DependencyInjection;

namespace FusionPay.EntityFrameworkCore;

public class EntityFrameworkCoreFusionPayDbSchemaMigrator
    : IFusionPayDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFusionPayDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the FusionPayDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FusionPayDbContext>()
            .Database
            .MigrateAsync();
    }
}
