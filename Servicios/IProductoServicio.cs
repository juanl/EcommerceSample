using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    interface IProductoServicio
    {
        IList<Producto> ObtenerPorDescripcion(string cadena);
        IList<Producto> ObtenerPorCategoria(Categoria categoria);
        Producto ObtenerPorId(int productoId);
        IList<Producto> ObtenerTodos();
        ResultadoOperacion GuardarProducto(Producto producto);
        ResultadoOperacion BorrarProducto(Producto producto);
    }
}
