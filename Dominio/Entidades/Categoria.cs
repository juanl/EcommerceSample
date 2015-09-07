using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
  public class Categoria
  {
    [ScaffoldColumn(false)]
    public int CategoriaID { get; set; }

    [Required, StringLength(100), Display(Name = "Name")]
    public string CategoriaNombre { get; set; }

    [Display(Name = "Product Description")]
    public string Descripcion { get; set; } 

    public virtual ICollection<Producto> Producto { get; set; }
  }
}