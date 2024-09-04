using despesas_blazor_webAssembly.Models;

namespace despesas_blazor_webAssembly.Service.Interface
{
    public interface IProdutoService
    {
        Task<List<Produto>> GetProguto();
        Task SaveProduto(List<Produto> produtoList);
    }
}
