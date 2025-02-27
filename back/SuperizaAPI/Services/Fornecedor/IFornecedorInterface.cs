using SuperizaAPI.Dto;
using SuperizaAPI.Models;

namespace SuperizaAPI.Services.Fornecedor;

public interface IFornecedorInterface
{
    Task<ResponseModel<List<FornecedorModel>>> ListarFornecedores();
    Task<ResponseModel<List<FornecedorModel>>> CriarFornecedores(FornecedorCriacaoDto fornecedorCriacaoDto);
    Task<ResponseModel<List<FornecedorModel>>> EditarFornecedores(FornecedorEdicaoDto fornecedorEdicaoDto);

    Task<ResponseModel<List<FornecedorModel>>> DeletarFornecedores(int idFornecedor);

}