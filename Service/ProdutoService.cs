using Blazored.LocalStorage;
using despesas_blazor_webAssembly.Models;
using despesas_blazor_webAssembly.Service.Interface;
using System.Text.Json;

namespace despesas_blazor_webAssembly.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly ILocalStorageService _localStorageService;

        public ProdutoService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        private string produtoLocalStrorageKay => "produtoKey";

        public async Task<List<Produto>> GetProguto()
        {
            var produtoJson = await _localStorageService.GetItemAsync<string>(produtoLocalStrorageKay);
            if (string.IsNullOrEmpty(produtoJson))
                return new();

            return JsonSerializer.Deserialize<List<Produto>>(produtoJson);
        }

        public async Task SaveProduto(List<Produto> produtoList)
        {
            var produtoJson = JsonSerializer.Serialize(produtoList);

            await _localStorageService.SetItemAsync(produtoJson, produtoLocalStrorageKay);
        }
    }
}
