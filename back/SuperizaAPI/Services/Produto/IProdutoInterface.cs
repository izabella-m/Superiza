using SuperizaAPI.Models;

namespace SuperizaAPI.Services.Produto;

public interface IProdutoInterface
{
    Task<ResponseModel<List<ProdutoModel>>> ListarProdutos();
}