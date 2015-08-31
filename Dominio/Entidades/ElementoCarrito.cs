using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
  public class ElementoCarrito
  {
    [Key]
    public string ElementoId { get; set; }

    public string CarritoId { get; set; }

    public int Cantidad { get; set; }

    public System.DateTime FechaCreado { get; set; }

    public int ProductoId { get; set; }

    public virtual Producto Producto { get; set; }

  }
}