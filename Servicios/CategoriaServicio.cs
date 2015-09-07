using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Servicios
{
    class CategoriaServicio: ICategoriaServicio
    {
        private ProductoContext contexto;
        public CategoriaServicio()
        {
            contexto = new ProductoContext();
        }

        public ResultadoOperacion BorrarCategoria(Categoria categoria)
        {
            var categoriaABorrar = (Categoria)contexto.Categorias
                   .Where(p => p.CategoriaID == categoria.CategoriaID)
                   .FirstOrDefault();

            if (categoriaABorrar != null)
            {
                contexto.Categorias.Remove(categoriaABorrar);
            }

            contexto.SaveChanges();
            throw new NotImplementedException();
        }

        public ResultadoOperacion GuardarCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Categoria ObtenerPorId(int categoriaId)
        {
            throw new NotImplementedException();
        }

        public IList<Producto> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
