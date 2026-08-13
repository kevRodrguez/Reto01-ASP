using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    public async Task<IActionResult> Index()
    {
        var productos = await _context.Productos.ToListAsync();

        var model = new CatalogoViewModel
        {
            Tienda = ObtenerTienda(),
            Productos = productos
        };

        ViewData["Titulo"] = "Catálogo de Productos";

        return View(model);
    }

    public async Task<IActionResult> Details(int id)
    {
        var producto = await _context.Productos.FirstOrDefaultAsync(p => p.Id == id);
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
