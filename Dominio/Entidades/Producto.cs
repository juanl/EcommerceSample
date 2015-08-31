using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
  public class Producto
  {
    [ScaffoldColumn(false)]
    public int ProductoID { get; set; }

    [Required, StringLength(100), Display(Name = "Name")]
    public string ProductoNombre { get; set; }

    [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
    public string Descripcion { get; set; }

    public string ImagenUbicacion { get; set; }

    [Display(Name = "Price")]
    public double? PrecioUnitario { get; set; }

    public int? CategoriaID { get; set; }

    public virtual Categoria Categoria { get; set; }
  }
}