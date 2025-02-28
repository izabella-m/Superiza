using SuperizaAPI.Data;
using SuperizaAPI.Models;
using Microsoft.EntityFrameworkCore;
using SuperizaAPI.Dto;

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
    
    public async Task<ResponseModel<List<ProdutoModel>>> CriarProdutos(ProdutoCriacaoDto produtoCriacaoDto)
    {
        ResponseModel<List<ProdutoModel>> resposta = new ResponseModel<List<ProdutoModel>>();

        try
        {
            var produtos = new ProdutoModel()
            {
                Nome = produtoCriacaoDto.Nome,
                Descricao = produtoCriacaoDto.Descricao,
                Preco = produtoCriacaoDto.Preco,
                QuantidadeEmEstoque = produtoCriacaoDto.QuantidadeEmEstoque
            };
            
            _context.Add(produtos);
            await _context.SaveChangesAsync();
            
            resposta.Dados = await _context.Produtos.ToListAsync();
            resposta.Mensagem = "Produto criado com sucesso";
            
            return resposta;
        }
        catch (Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
    }
    
    public async Task<ResponseModel<List<ProdutoModel>>> EditarProdutos(ProdutoEdicaoDto produtoEdicaoDto)
    {
        ResponseModel<List<ProdutoModel>> resposta = new ResponseModel<List<ProdutoModel>>();

        try
        {
            var produto = await _context.Produtos.FirstOrDefaultAsync(fornecedorBanco => fornecedorBanco.Id == produtoEdicaoDto.Id);
            if (produto == null)
            {
                resposta.Mensagem = "Nenhum produto encontrado";
                return resposta;
            }
            
            produto.QuantidadeEmEstoque = produtoEdicaoDto.QuantidadeEmEstoque;
            produto.Preco = produtoEdicaoDto.Preco;
            
            _context.Update(produto);
            await _context.SaveChangesAsync();
            
            resposta.Dados = await _context.Produtos.ToListAsync();
            resposta.Mensagem = "Produto editado com sucesso";
            
            return resposta;
        }
        catch (Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
    }
}