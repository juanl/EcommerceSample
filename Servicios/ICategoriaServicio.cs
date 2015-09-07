using Dominio.Entidades;
using Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface ICategoriaServicio
    {
        IList<CategoriaDTO> ObtenerPorDescripcion(string cadena);
        CategoriaDTO ObtenerPorId(int categoriaId);
        IList<CategoriaDTO> ObtenerTodos();
        ResultadoOperacion GuardarCategoria(CategoriaDTO _categoriaDTO);
        ResultadoOperacion EditarCategoria(CategoriaDTO _categoriaDTO);
        ResultadoOperacion BorrarCategoria(CategoriaDTO _categoriaDTO);
    }
}
