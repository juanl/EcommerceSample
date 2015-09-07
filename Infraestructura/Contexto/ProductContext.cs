using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Entidades
{
  public class ProductoContext : DbContext
  {
    public ProductoContext()
      : base("Ecommerce")
    {
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<ElementoCarrito> ElementosCarrito { get; set; }
    public DbSet<Orden> Ordenes { get; set; }
    public DbSet<OrdenDetalle> OrdenDetalle { get; set; }
  }
}