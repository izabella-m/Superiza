using System.Text.Json.Serialization;

namespace SuperizaAPI.Models;

public class ProdutoModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    public decimal Preco { get; set; }
    
    [JsonIgnore]
    public List<ItemPedidoModel> ItensPedido { get; set; }  // Relacionamento com ItemPedido

}