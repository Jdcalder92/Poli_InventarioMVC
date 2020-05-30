using Microsoft.EntityFrameworkCore;

namespace InventatioMVC.Models
{
    public class MvcProductoContext : DbContext
    {
        public MvcProductoContext (DbContextOptions<MvcProductoContext> options)
            : base(options)
        {
        }

        public DbSet<InventatioMVC.Models.Productos> Producto { get; set; }
    }
}

