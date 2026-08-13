using Microsoft.AspNetCore.Mvc;
using Reto01_ASP.Models;

namespace Reto01_ASP.Controllers;

public class ProductosController : Controller
{

    private List<Producto> ObtenerProductos()
{
    return new List<Producto>
    {
        new Producto { Id = 1, Nombre = "Laptop",  Descripcion = "Computadora portátil para trabajo y estudio", Precio = 1200, Stock = 5,  Categoria = "Computación" },
        new Producto { Id = 2, Nombre = "Mouse",   Descripcion = "Mouse inalámbrico ergonómico", Precio = 25,   Stock = 50, Categoria = "Accesorios" },
        new Producto { Id = 3, Nombre = "Teclado", Descripcion = "Teclado mecánico RGB", Precio = 60,   Stock = 20, Categoria = "Accesorios" },
        new Producto { Id = 4, Nombre = "Monitor", Descripcion = "Monitor 27 pulgadas Full HD", Precio = 300,  Stock = 10, Categoria = "Computación" },
        new Producto { Id = 5, Nombre = "Silla",   Descripcion = "Silla ergonómica de oficina", Precio = 150,  Stock = 8,  Categoria = "Hogar" }
    };
}
    public IActionResult Index()
    {
        var productos = ObtenerProductos();

        ViewBag.CantidadProductos = productos.Count;
        ViewBag.NombreTienda = "WebAcademia";
        ViewData["Titulo"] = "Catálogo de Productos";

        return View(productos);
    }

    public IActionResult Details(int id)
{
    var producto = ObtenerProductos().FirstOrDefault(p => p.Id == id);
    if (producto == null) return NotFound();
    return View(producto);
}
}
