using Microsoft.AspNetCore.Mvc;
using Reto01_ASP.Models;

namespace Reto01_ASP.Controllers;

public class ProductosController : Controller
{

    private List<Producto> ObtenerProductos()
{
    return new List<Producto>
    {
        new Producto { Id = 1, Nombre = "Laptop",  Precio = 1200, Stock = 5,  Categoria = "Computación" },
        new Producto { Id = 2, Nombre = "Mouse",   Precio = 25,   Stock = 50, Categoria = "Accesorios" },
        new Producto { Id = 3, Nombre = "Teclado", Precio = 60,   Stock = 20, Categoria = "Accesorios" },
        new Producto { Id = 4, Nombre = "Monitor", Precio = 300,  Stock = 10, Categoria = "Computación" },
        new Producto { Id = 5, Nombre = "Silla",   Precio = 150,  Stock = 8,  Categoria = "Hogar" }
    };
}
    public IActionResult Index()
    {
        var productos = ObtenerProductos();

        ViewBag.CantidadProductos = productos.Count;
        ViewBag.NombreTienda = "WebAcademia";
        ViewData["Titulo"] = "Catálogo de Productos";

        return View();
    }
}