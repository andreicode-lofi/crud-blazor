using Blazored.LocalStorage;
using despesas_blazor_webAssembly.Models;
using despesas_blazor_webAssembly.Service.Interface;
using System.Text.Json;

namespace despesas_blazor_webAssembly.Service
{
    public class SpendService : ISpendService
    {
        private readonly ILocalStorageService _localStorageService;

        public SpendService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        private string spendsLocalStoragekey => "spendkey";

        public async Task<List<Spend>> GetSpends()
        {
            var spendsJson = await _localStorageService.GetItemAsync<string>(spendsLocalStoragekey);
            if (string.IsNullOrWhiteSpace(spendsJson))
                return new();

            return JsonSerializer.Deserialize<List<Spend>>(spendsJson);
        }

        public async Task SaveSpends(List<Spend> spends)
        {
            var spendsJson = JsonSerializer.Serialize(spends);

            await _localStorageService.SetItemAsync(spendsLocalStoragekey, spendsJson);
        }
    }
}
