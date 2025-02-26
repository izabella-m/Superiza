var builder = WebApplication.CreateBuilder(args);

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