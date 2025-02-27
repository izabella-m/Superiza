using Microsoft.EntityFrameworkCore;
using SuperizaAPI.Data;
using SuperizaAPI.Models;

namespace SuperizaAPI.Services.Fornecedor;

public class FornecedorService : IFornecedorInterface
{

    private readonly AppDbContext _context;

    public FornecedorService(AppDbContext context)
    {
        _context = context;
    }


    public async Task<ResponseModel<List<FornecedorModel>>> BuscarFornecedores()
    {
        ResponseModel<List<FornecedorModel>> resposta = new ResponseModel<List<FornecedorModel>>();
        try
        {
            var fornecedores = await _context.Fornecedores.ToListAsync();

            resposta.Dados = fornecedores;
            resposta.Mensagem = "Todos os fornecedores foram encontrados";
        }
        catch (Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
        return resposta; 
    }


    public Task<ResponseModel<FornecedorModel>> BuscarFornecedoresPorId(int idFornecedor)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<FornecedorModel>> CriarFornecedores()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<FornecedorModel>> DeletarFornecedores()
    {
        throw new NotImplementedException();
    }
}