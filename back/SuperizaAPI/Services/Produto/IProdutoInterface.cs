using SuperizaAPI.Dto;
using SuperizaAPI.Models;

namespace SuperizaAPI.Services.Produto;

public interface IProdutoInterface
{
    Task<ResponseModel<List<ProdutoModel>>> ListarProdutos();
    Task<ResponseModel<List<ProdutoModel>>> CriarProdutos(ProdutoCriacaoDto produtoCriacaoDto);
    Task<ResponseModel<List<ProdutoModel>>> EditarProdutos(ProdutoEdicaoDto produtoEdicaoDto);

}