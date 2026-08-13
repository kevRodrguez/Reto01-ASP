using Microsoft.EntityFrameworkCore;
using Reto01_ASP.Models;

namespace Reto01_ASP.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Producto> Productos { get; set; }
}
