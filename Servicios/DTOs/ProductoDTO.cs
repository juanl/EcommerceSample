using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DTOs
{
    public class ProductoDTO
    {

        public int ProductoID { get; set; }
        public string ProductoNombre { get; set; }
        public string Descripcion { get; set; }

        public string ImagenUbicacion { get; set; }

        public double? PrecioUnitario { get; set; }

        public int? CategoriaID { get; set; }
    }
}
