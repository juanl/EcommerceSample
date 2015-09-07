using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    interface ICategoriaServicio
    {
        Categoria ObtenerPorId(int categoriaId);
        IList<Producto> ObtenerTodos();
        ResultadoOperacion GuardarCategoria(Categoria categoria);
        ResultadoOperacion BorrarCategoria(Categoria categoria);
    }
}
