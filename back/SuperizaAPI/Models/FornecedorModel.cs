using System.Text.Json.Serialization;

namespace SuperizaAPI.Models;

public class FornecedorModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Contato { get; set; }
}