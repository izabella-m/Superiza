namespace SuperizaAPI.Models;

public class PedidoModel
{
    public int Id { get; set; }             
    public DateTime DataPedido { get; set; } 
    public DateTime DataEntrega { get; set; } 

    public int FornecedorId { get; set; }  // Chave estrangeira
    public FornecedorModel Fornecedor { get; set; }  // Relacionamento com Fornecedor (sem o "Id")
    
    public string Produtos { get; set; }
}