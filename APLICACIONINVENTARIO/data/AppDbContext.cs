using APLICACIONINVENTARIO.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace APLICACIONINVENTARIO.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(p => p.Nombre).IsRequired().HasMaxLength(200);
                entity.Property(p => p.Precio).HasPrecision(18, 2);
            });

        
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Laptop Dell",
                    Descripcion = "Laptop Dell Inspiron 15",
                    Precio = 599.99m,
                    Cantidad = 10,
                    StockMinimo = 5,
                    FechaCreacion = DateTime.Now,
                    Activo = true
                }
            );
        }
    }
}
