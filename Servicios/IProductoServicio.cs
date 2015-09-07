using Dominio.Entidades;
using Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    interface IProductoServicio
    {
        IList<ProductoDTO> ObtenerPorDescripcion(string cadena);
        IList<ProductoDTO> ObtenerPorCategoria(CategoriaDTO categoria);
        ProductoDTO ObtenerPorId(int productoId);
        IList<ProductoDTO> ObtenerTodos();
        ResultadoOperacion GuardarProducto(ProductoDTO _productoDTO);
        ResultadoOperacion EditarProducto(ProductoDTO _productoDTO);
        ResultadoOperacion BorrarProducto(ProductoDTO _productoDTO);
    }
}
