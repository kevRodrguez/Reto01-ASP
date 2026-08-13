namespace Reto01_ASP.Models;

public class CatalogoViewModel
{
    public Tienda Tienda { get; set; } = new();
    public List<Producto> Productos { get; set; } = new();
    public int CantidadProductos => Productos.Count;
}
