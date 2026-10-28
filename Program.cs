using Exo.WebApi.Contexts;
using Exo.WebApi.Repositories;
using Microsoft.EntityFrameworkCore; // Adicionado para poder usar o UseSqlServer

var builder = WebApplication.CreateBuilder(args);

// 1. Configuração do Banco de Dados lendo o appsettings.json
builder.Services.AddDbContext<ExoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();

var app = builder.Build();

// 2. Configurações de rotas modernas (substitui o UseRouting e UseEndpoints antigos)
app.MapControllers();

app.Run();
