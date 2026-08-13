using Reto01_ASP.Models;

namespace Reto01_ASP.Data;

public static class DbInitializer
{
    public static void Seed(AppDbContext context)
    {
        if (context.Productos.Any())
        {
            return;
        }

        context.Productos.Add(new Producto { Nombre = "Laptop", Precio = 1200, Stock = 5, Descripcion = "Computadora portátil para trabajo y estudio", Categoria = "Computación" });
        context.Productos.Add(new Producto { Nombre = "Mouse", Precio = 25, Stock = 50, Descripcion = "Mouse inalámbrico ergonómico", Categoria = "Accesorios" });
        context.Productos.Add(new Producto { Nombre = "Teclado", Precio = 60, Stock = 20, Descripcion = "Teclado mecánico RGB", Categoria = "Accesorios" });
        context.Productos.Add(new Producto { Nombre = "Monitor", Precio = 300, Stock = 10, Descripcion = "Monitor 27 pulgadas Full HD", Categoria = "Computación" });
        context.Productos.Add(new Producto { Nombre = "Silla", Precio = 150, Stock = 8, Descripcion = "Silla ergonómica de oficina", Categoria = "Hogar" });
        context.SaveChanges();
    }
}
