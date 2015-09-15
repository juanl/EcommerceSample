using Servicios;
using Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    
    [RoutePrefix("api/Producto")]
    public class ProductoController : ApiController
    {
        public IList<ProductoDTO> ObtenerPorDescripcion(string cadena)
        {
            ProductoServicio serv = new ProductoServicio();
            IList<ProductoDTO> productos = serv.ObtenerPorDescripcion(cadena);
            return productos;
        }
        public IList<ProductoDTO> ObtenerPorCategoria(CategoriaDTO categoria)
        {
            ProductoServicio serv = new ProductoServicio();
            IList<ProductoDTO> producto = serv.ObtenerPorCategoria(categoria);
            return producto;
        }
        public ProductoDTO ObtenerPorId(int productoId)
        {
            ProductoServicio serv = new ProductoServicio();
            ProductoDTO producto = serv.ObtenerPorId(productoId);
            return producto;
        }
        [HttpGet]
        public IList<ProductoDTO> ObtenerTodos()
        {
            ProductoServicio serv = new ProductoServicio();
            IList<ProductoDTO> productos = serv.ObtenerTodos();
            return productos;
        }
        public ResultadoOperacion GuardarProducto(ProductoDTO _productoDTO)
        {
            ProductoServicio serv = new ProductoServicio();
            ResultadoOperacion resultado = serv.GuardarProducto(_productoDTO);
            return resultado;
        }
        public ResultadoOperacion EditarProducto(ProductoDTO _productoDTO)
        {
            ProductoServicio serv = new ProductoServicio();
            ResultadoOperacion resultado = serv.EditarProducto(_productoDTO);
            return resultado;
        }
        public ResultadoOperacion BorrarProducto(ProductoDTO _productoDTO)
        {
            ProductoServicio serv = new ProductoServicio();
            ResultadoOperacion resultado = serv.BorrarProducto(_productoDTO);
            return resultado;
        }
    }
}
