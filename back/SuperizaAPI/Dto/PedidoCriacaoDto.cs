namespace SuperizaAPI.Dto;

public class PedidoCriacaoDto
{
    public DateTime DataEntrega { get; set; } // Data de entrega escolhida pelo usuário

    public int FornecedorId { get; set; } // ID do fornecedor escolhido

    public List<ProdutoPedidoDto> Produtos { get; set; } // Lista de produtos no pedido
}
public class ProdutoPedidoDto
{
    public int ProdutoId { get; set; } // ID do produto
    public int Quantidade { get; set; } // Quantidade solicitada
}