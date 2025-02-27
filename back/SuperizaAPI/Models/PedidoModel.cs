namespace SuperizaAPI.Models;

public class PedidoModel
{
    public int Id { get; set; }              // Identificador único do pedido
    public DateTime DataPedido { get; set; } // Data do pedido
    public DateTime DataEntrega { get; set; } // Data de entrega

    public int FornecedorId { get; set; }  // Chave estrangeira
    public FornecedorModel Fornecedor { get; set; }  // Relacionamento com Fornecedor (sem o "Id")

    public ICollection<ItemPedidoModel> ItensPedido { get; set; }
}