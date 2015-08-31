using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
  public class OrdenDetalle
  {
    public int OrdenDetalleId { get; set; }

    public int OrdenId { get; set; }

    public string NombreUsuario { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public double? PrecioUnitario { get; set; }

  }
}