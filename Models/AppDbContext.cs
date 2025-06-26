using Microsoft.EntityFrameworkCore;
using ListaPedidos.Models;

namespace ListaPedidos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
