using Microsoft.EntityFrameworkCore;

namespace PedPizzaApplication.Models
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=DBPedidoPizza.sqlite");
        }
        public DbSet<Promocion> promocion { get; set; }
        public DbSet<Pedido> pedido { get; set; }
        public DbSet<DetallePedido> detallePedido { get; set; }
        public DbSet<Producto> producto { get; set; }
    }
}
