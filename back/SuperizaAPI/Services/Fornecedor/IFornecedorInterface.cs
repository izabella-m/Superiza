using SuperizaAPI.Models;

namespace SuperizaAPI.Services.Fornecedor;

public interface IFornecedorInterface
{
    Task<ResponseModel<List<FornecedorModel>>> ListarFornecedores();
    Task<ResponseModel<FornecedorModel>> CriarFornecedores();
    Task<ResponseModel<FornecedorModel>> DeletarFornecedores();

}