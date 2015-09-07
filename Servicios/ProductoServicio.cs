using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Servicios.DTOs;

namespace Servicios
{
    public class ProductoServicio : IProductoServicio
    {
        ProductoContext _context = new ProductoContext();
        public IList<ProductoDTO> ObtenerPorDescripcion(string cadena)
        {
            var listaProductos = _context.Productos.Where(x => x.Descripcion.Contains(cadena))
                .Select(p => new ProductoDTO
                {
                    ProductoID = p.ProductoID,
                    ProductoNombre = p.ProductoNombre,
                    Descripcion = p.Descripcion,
                    PrecioUnitario = p.PrecioUnitario,
                    ImagenUbicacion = p.ImagenUbicacion,
                    CategoriaID = p.CategoriaID
                }).ToList();
            return listaProductos;
        }

        public IList<ProductoDTO> ObtenerPorCategoria(CategoriaDTO categoria)
        {
            var listaProductos = _context.Productos.Where(x => x.CategoriaID == categoria.CategoriaID)
                .Select(p => new ProductoDTO
                {
                    ProductoID = p.ProductoID,
                    ProductoNombre = p.ProductoNombre,
                    Descripcion = p.Descripcion,
                    PrecioUnitario = p.PrecioUnitario,
                    ImagenUbicacion = p.ImagenUbicacion,
                    CategoriaID = p.CategoriaID
                }).ToList();
            return listaProductos;
        }

        public ProductoDTO ObtenerPorId(int productoId)
        {
            var producto = _context.Productos.Where(x => x.ProductoID == productoId)
                .Select(p => new ProductoDTO
                {
                    ProductoID = p.ProductoID,
                    ProductoNombre = p.ProductoNombre,
                    Descripcion = p.Descripcion,
                    PrecioUnitario = p.PrecioUnitario,
                    ImagenUbicacion = p.ImagenUbicacion,
                    CategoriaID = p.CategoriaID
                }).FirstOrDefault();
            return producto;
        }

        public IList<ProductoDTO> ObtenerTodos()
        {
            var listaProductos = _context.Productos.Select(p => new ProductoDTO
            {
                ProductoID = p.ProductoID,
                ProductoNombre = p.ProductoNombre,
                Descripcion = p.Descripcion,
                PrecioUnitario = p.PrecioUnitario,
                ImagenUbicacion = p.ImagenUbicacion,
                CategoriaID = p.CategoriaID
            }).ToList();
            return listaProductos;
        }
        public Producto ConvertirDesdeDTO(ProductoDTO _productoDTO)
        {
            var producto = new Producto()
            {
                ProductoID = _productoDTO.ProductoID,
                ProductoNombre = _productoDTO.ProductoNombre,
                Descripcion = _productoDTO.Descripcion,
                ImagenUbicacion = _productoDTO.ImagenUbicacion,
                PrecioUnitario = _productoDTO.PrecioUnitario,
                CategoriaID = _productoDTO.CategoriaID
            };
            return producto;
        }

        public ResultadoOperacion GuardarProducto(ProductoDTO _productoDTO)
        {
            ResultadoOperacion res = new ResultadoOperacion();
            try
            {
                var producto = ConvertirDesdeDTO(_productoDTO);
                _context.Productos.Add(producto);
                _context.SaveChanges();
                res.Mensaje = "Operacion finalizada con exito.";
                res.Resultado = Resultado.ok;
                return res;
            }
            catch
            {
                res.Mensaje = "Ocurrió un Error durante la operacion.";
                res.Resultado = Resultado.Error;
                return res;
            }
        }

        public ResultadoOperacion BorrarProducto(ProductoDTO _productoDTO)
        {
            ResultadoOperacion res = new ResultadoOperacion();
            try
            {
                var producto = ConvertirDesdeDTO(_productoDTO);
                _context.Productos.Remove(producto);
                _context.SaveChanges();
                res.Mensaje = "Operacion finalizada con éxito.";
                res.Resultado = Resultado.ok;
                return res;
            }
            catch
            {
                res.Mensaje = "Ocurrió un Error durante la operación.";
                res.Resultado = Resultado.Error;
                return res;
            }
        }
        public ResultadoOperacion EditarProducto(ProductoDTO _productoDTO)
        {
            ResultadoOperacion res = new ResultadoOperacion();
            try
            {
                var producto = ConvertirDesdeDTO(_productoDTO);
                _context.SaveChanges();
                res.Mensaje = "Operacion finalizada con éxito.";
                res.Resultado = Resultado.ok;
                return res;
            }
            catch
            {
                res.Mensaje = "Ocurrió un Error durante la operación.";
                res.Resultado = Resultado.Error;
                return res;
            }
        }
    }
}
