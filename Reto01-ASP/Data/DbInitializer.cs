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

        var computacion = new Categoria
        {
            Nombre = "Computación",
            Descripcion = "Equipos y componentes de cómputo"
        };
        var accesorios = new Categoria
        {
            Nombre = "Accesorios",
            Descripcion = "Periféricos y complementos"
        };
        var hogar = new Categoria
        {
            Nombre = "Hogar",
            Descripcion = "Artículos para oficina y hogar"
        };

        context.Categorias.AddRange(computacion, accesorios, hogar);
        context.SaveChanges();

        context.Productos.Add(new Producto { Nombre = "Laptop", Descripcion = "Computadora portátil para trabajo y estudio", Precio = 1200, Stock = 5, CategoriaId = computacion.Id });
        context.Productos.Add(new Producto { Nombre = "Mouse", Descripcion = "Mouse inalámbrico ergonómico", Precio = 25, Stock = 50, CategoriaId = accesorios.Id });
        context.Productos.Add(new Producto { Nombre = "Teclado", Descripcion = "Teclado mecánico RGB", Precio = 60, Stock = 20, CategoriaId = accesorios.Id });
        context.Productos.Add(new Producto { Nombre = "Monitor", Descripcion = "Monitor 27 pulgadas Full HD", Precio = 300, Stock = 10, CategoriaId = computacion.Id });
        context.Productos.Add(new Producto { Nombre = "Silla", Descripcion = "Silla ergonómica de oficina", Precio = 150, Stock = 8, CategoriaId = hogar.Id });
        context.SaveChanges();
    }
}
