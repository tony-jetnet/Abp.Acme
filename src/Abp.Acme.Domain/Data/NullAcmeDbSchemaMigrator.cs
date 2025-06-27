using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.Acme.Data;

/* This is used if database provider does't define
 * IAcmeDbSchemaMigrator implementation.
 */
public class NullAcmeDbSchemaMigrator : IAcmeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
