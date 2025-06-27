using System.Threading.Tasks;

namespace Abp.Acme.Sandbox;

public interface IBatchInsertAppService
{
    Task<int> GetRun();
}