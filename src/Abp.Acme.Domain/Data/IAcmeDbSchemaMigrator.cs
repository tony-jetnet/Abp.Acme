using System.Threading.Tasks;

namespace Abp.Acme.Data;

public interface IAcmeDbSchemaMigrator
{
    Task MigrateAsync();
}
