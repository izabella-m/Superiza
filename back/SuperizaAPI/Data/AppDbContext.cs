using Microsoft.EntityFrameworkCore;
using SuperizaAPI.Models;


namespace SuperizaAPI.Data;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<FornecedorModel> Fornecedores { get; set; }
    public DbSet<ProdutoModel> Produtos { get; set; }
    public DbSet<PedidoModel> Pedidos { get; set; }
}


