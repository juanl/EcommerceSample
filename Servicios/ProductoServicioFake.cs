﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Infraestructura.Context;

namespace Servicios
{
    class ProductoServicioFake : IProductoServicio
    {
        Contexto _context = new Contexto();
        public ResultadoOperacion BorrarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public ResultadoOperacion GuardarProducto(Producto producto)
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
    }
}
