using SuperizaAPI.Data;
using SuperizaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SuperizaAPI.Services.Produto;

public class ProdutoService : IProdutoInterface
{
    private readonly AppDbContext _context;

    public ProdutoService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<ResponseModel<List<ProdutoModel>>> ListarProdutos()
    {
        ResponseModel<List<ProdutoModel>> resposta = new ResponseModel<List<ProdutoModel>>();
        try
        {
            var produtos = await _context.Produtos.ToListAsync();

            resposta.Dados = produtos;
            resposta.Mensagem = "Todos os produtos foram encontrados";
        }
        catch (Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
        return resposta; 
    }
}