using SuperizaAPI.Dto;
using SuperizaAPI.Models;

namespace SuperizaAPI.Services.Pedido;

public interface IPedidoInterface
{
    Task<ResponseModel<List<PedidoModel>>> ListarPedidos();
    Task<ResponseModel<List<PedidoModel>>> CriarPedidos(PedidoCriacaoDto pedidoCriacao);
    Task<ResponseModel<List<PedidoModel>>> DeletarPedidos(int idPedido);
}