namespace SuperizaAPI.Models;

public class ItemPedidoModel
{
    public int Id { get; set; }
    public int Quantidade { get; set; }

    public int PedidoId { get; set; }
    public PedidoModel Pedido { get; set; }  // Relacionamento com Pedido
    
    public int ProdutoId { get; set; }
    public ProdutoModel Produto { get; set; }  // Relacionamento com Produto
    
}