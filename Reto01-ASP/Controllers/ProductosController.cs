using Microsoft.AspNetCore.Mvc;
using Reto01_ASP.Data;
using Reto01_ASP.Models;

namespace Reto01_ASP.Controllers;

public class ProductosController : Controller
{
    private readonly AppDbContext _context;

    public ProductosController(AppDbContext context)
    {
        _context = context;
    }

    private Tienda ObtenerTienda()
    {
        return new Tienda
        {
            Nombre = "WebAcademia",
            Descripcion = "Tienda en línea de tecnología y accesorios para estudiantes y profesionales.",
            Email = "contacto@webacademia.edu.sv",
            Telefono = "+503 2222-0000",
            Ubicacion = "Santa Ana, El Salvador"
        };
    }

    public IActionResult Index()
    {
        var productos = _context.Productos.ToList();

        var model = new CatalogoViewModel
        {
            Tienda = ObtenerTienda(),
            Productos = productos
        };

        ViewData["Titulo"] = "Catálogo de Productos";

        return View(model);
    }

    public IActionResult Details(int id)
    {
        var producto = _context.Productos.FirstOrDefault(p => p.Id == id);
        if (producto == null)
        {
            return NotFound();
        }

        var model = new ProductoDetalleViewModel
        {
            Producto = producto,
            Tienda = ObtenerTienda()
        };

        return View(model);
    }
}
