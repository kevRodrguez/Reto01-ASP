using Microsoft.EntityFrameworkCore;
using Reto01_ASP.Models;

namespace Reto01_ASP.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Producto> Productos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>()
            .HasMany(c => c.Productos)
            .WithOne(p => p.Categoria)
            .HasForeignKey(p => p.CategoriaId);
    }
}
