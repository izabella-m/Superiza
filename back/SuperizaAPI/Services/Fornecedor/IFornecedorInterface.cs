using SuperizaAPI.Models;

namespace SuperizaAPI.Services.Fornecedor;

public interface IFornecedorInterface
{
    Task<ResponseModel<List<FornecedorModel>>> BuscarFornecedores();
    Task<ResponseModel<FornecedorModel>> BuscarFornecedoresPorId(int idFornecedor);
    Task<ResponseModel<FornecedorModel>> CriarFornecedores();
    Task<ResponseModel<FornecedorModel>> DeletarFornecedores();

}