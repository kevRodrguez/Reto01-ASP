namespace Reto01_ASP.Models;

public class ProductoDetalleViewModel
{
    public Producto Producto { get; set; } = new();
    public Tienda Tienda { get; set; } = new();
}
