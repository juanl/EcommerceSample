using Dominio.Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApiProject.Code
{
    public class CarritoCompra : ICarritoCompra
    {
        IHttpSessionState ProductosRepository { get; set; }
        private string key = "CarritoCompra";
        IList<ElementoCarrito> _Productos;
        public IList<ElementoCarrito> Productos
        {
            get
            {
                if (_Productos == null)
                    _Productos = (IList<ElementoCarrito>)ProductosRepository[key];
                return _Productos;
            }
            set
            {
                _Productos = value;
                ProductosRepository[key] = value;
            }
        }

        public CarritoCompra(IHttpSessionState Session)
        {
            ProductosRepository = Session;
        }
        public ResultadoOperacion AgregarProducto(ElementoCarrito item)
        {
            if (ExisteElemento(item))
            {
                AumentarCantidad(item, 1);
            }
            else
            {
                AgregarProductoEnCarrito(item);
            }
            return new ResultadoOperacion()
            {
                Mensaje = "Agregado Satisfactoriamente",
                Resultado = Resultado.ok
            };
        }

        private void AgregarProductoEnCarrito(ElementoCarrito item)
        {
            this.Productos.Add(item);
        }

        /*        private void AumentarCantidad(ElementoCarrito item)
                {
                    foreach (ElementoCarrito producto in this.Productos)
                    {
                        if (producto.CompareTo(item) > 0)
                            producto.Cantidad++;
                    }
                }
                */
        private bool ExisteElemento(ElementoCarrito item)
        {
            return Productos.Any(p => p.ProductoId == item.ProductoId);
        }

        public ResultadoOperacion AumentarCantidad(ElementoCarrito item, int cantidad)
        {
            ResultadoOperacion mensaje = new ResultadoOperacion();

            var prod = Productos.SingleOrDefault(p => p.ProductoId == item.ProductoId);
            if (prod != null)
            {
                prod.Cantidad += cantidad;
                if (prod.Cantidad <= 0)
                {
                    mensaje = EliminarProducto(item);
                }
            }
            else
            {
                mensaje.Mensaje = "No existe el producto en el carrito de compra";
                mensaje.Resultado = Resultado.Error;
            }
            return mensaje;
        }

        public ResultadoOperacion EliminarProducto(ElementoCarrito item)
        {
            Productos.Remove(item);
            return new ResultadoOperacion() { };
        }
        public IList<ElementoCarrito> ListarProductos()
        {
            return Productos;
        }
    }

    public interface ICarritoCompra
    {
        ResultadoOperacion AgregarProducto(ElementoCarrito item);
        ResultadoOperacion EliminarProducto(ElementoCarrito item);
        ResultadoOperacion AumentarCantidad(ElementoCarrito item, int cantidad);
        IList<ElementoCarrito> ListarProductos();
    }
}