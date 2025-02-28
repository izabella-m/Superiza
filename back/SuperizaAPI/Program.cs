using Microsoft.EntityFrameworkCore;
using SuperizaAPI.Data;
using SuperizaAPI.Services.Fornecedor;
using SuperizaAPI.Services.Pedido;
using SuperizaAPI.Services.Produto;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IFornecedorInterface, FornecedorService>();
builder.Services.AddScoped<IProdutoInterface, ProdutoService>();
builder.Services.AddScoped<IPedidoInterface, PedidoService>();

// Configurar o DbContext com SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source=SuperizaControl.db");
});

// Adicionar os serviços de Controllers
builder.Services.AddControllers();

// Adicionar os serviços do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do Swagger no pipeline de requisição
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  // Habilita o Swagger
    app.UseSwaggerUI();  // Habilita a interface do Swagger
}

// Configuração das rotas da API
app.UseHttpsRedirection();
app.MapControllers();  // Habilita as rotas dos controllers

app.Run();