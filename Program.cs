using ListaPedidos.Data;                // Importa seu DbContext
using Microsoft.EntityFrameworkCore;   // Importa EF Core

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao container
builder.Services.AddControllersWithViews();

// Configura o DbContext para usar banco InMemory chamado "PedidosDB"
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("PedidosDB"));

var app = builder.Build();

// Configuração do pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configura a rota padrão: HomeController / Index action
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
