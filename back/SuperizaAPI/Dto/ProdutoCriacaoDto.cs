using SuperizaAPI.Models;

namespace SuperizaAPI.Dto;

public class ProdutoCriacaoDto
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    public decimal Preco { get; set; }
}