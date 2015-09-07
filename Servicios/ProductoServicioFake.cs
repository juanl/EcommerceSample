using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Infraestructura.Context;
using Servicios.DTOs;

namespace Servicios
{
    public class ProductoServicioFake : IProductoServicio
    {
        Contexto _context = new Contexto();

        public ResultadoOperacion BorrarProducto(ProductoDTO _productoDTO)
        {
            throw new NotImplementedException();
        }

        public ResultadoOperacion BorrarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public ResultadoOperacion EditarProducto(ProductoDTO _productoDTO)
        {
            throw new NotImplementedException();
        }

        public ResultadoOperacion GuardarProducto(ProductoDTO _productoDTO)
        {
            throw new NotImplementedException();
        }

        public ResultadoOperacion GuardarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public IList<ProductoDTO> ObtenerPorCategoria(CategoriaDTO categoria)
        {
            throw new NotImplementedException();
        }

        public IList<Producto> ObtenerPorCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public IList<Producto> ObtenerPorDescripcion(string cadena)
        {
            throw new NotImplementedException();
        }

        public Producto ObtenerPorId(int productoId)
        {
            throw new NotImplementedException();
        }

        public IList<Producto> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        IList<ProductoDTO> IProductoServicio.ObtenerPorDescripcion(string cadena)
        {
            throw new NotImplementedException();
        }

        ProductoDTO IProductoServicio.ObtenerPorId(int productoId)
        {
            throw new NotImplementedException();
        }

        IList<ProductoDTO> IProductoServicio.ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
