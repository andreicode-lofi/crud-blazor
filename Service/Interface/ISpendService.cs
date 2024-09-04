using despesas_blazor_webAssembly.Models;

namespace despesas_blazor_webAssembly.Service.Interface
{
    public interface ISpendService
    {
        Task<List<Spend>> GetSpends();
        Task SaveSpends(List<Spend> spends);
    }
}
