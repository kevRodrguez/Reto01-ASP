namespace Reto01_ASP.Models;
//Entidad producto para db context

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Categoria { get; set; }
    
    public int CategoriaId { get; set; }
}