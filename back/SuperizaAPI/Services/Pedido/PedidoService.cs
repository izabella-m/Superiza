using Microsoft.EntityFrameworkCore;
using SuperizaAPI.Data;
using SuperizaAPI.Dto;
using SuperizaAPI.Models;

namespace SuperizaAPI.Services.Pedido;

public class PedidoService : IPedidoInterface
{
    
    private readonly AppDbContext _context;

    public PedidoService(AppDbContext context)
    {
        _context = context;
    }

    public Task<ResponseModel<List<PedidoModel>>> ListarPedidos()
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseModel<List<PedidoModel>>> CriarPedidos(PedidoCriacaoDto pedidoCriacaoDto)
    {
        ResponseModel<List<PedidoModel>> resposta = new ResponseModel<List<PedidoModel>>();

        try
        {
            var pedidos = new PedidoModel()
            {
                DataPedido = DateTime.Now, // Gerando a data automaticamente
                DataEntrega = pedidoCriacaoDto.DataEntrega, 
                FornecedorId = pedidoCriacaoDto.FornecedorId,
                Produtos = string.Join(", ", pedidoCriacaoDto.Produtos.Select(p => $"ProdutoId: {p.ProdutoId}, Quantidade: {p.Quantidade}"))
            };

            _context.Add(pedidos);
            await _context.SaveChangesAsync();

            resposta.Dados = await _context.Pedidos
                .Include(p => p.Fornecedor) // Carrega o fornecedor associado ao pedido
                .ToListAsync();

            resposta.Mensagem = "Pedido criado com sucesso";

            return resposta;
        }
        catch (Exception e)
        {
            resposta.Mensagem = e.Message;
            resposta.Status = false;
            return resposta;
        }
    }

    public Task<ResponseModel<List<PedidoModel>>> DeletarPedidos(int idPedido)
    {
        throw new NotImplementedException();
    }
}