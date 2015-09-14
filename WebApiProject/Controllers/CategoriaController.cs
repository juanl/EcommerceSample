using Servicios;
using Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.Controllers
{
    [Authorize]
    [RoutePrefix("api/Categoria")]
    public class CategoriaController : ApiController
    {
        public IList<CategoriaDTO> ObtenerPorDescripcion(string cadena)
        {
            CategoriaServicio serv = new CategoriaServicio();
            IList<CategoriaDTO> categorias = serv.ObtenerPorDescripcion(cadena);
            return categorias;
        }
        public CategoriaDTO ObtenerPorId(int categoriaId)
        {
            CategoriaServicio serv = new CategoriaServicio();
            CategoriaDTO categoria = serv.ObtenerPorId(categoriaId);
            return categoria;
        }
        public IList<CategoriaDTO> ObtenerTodos()
        {
            CategoriaServicio serv = new CategoriaServicio();
            IList<CategoriaDTO> categorias = serv.ObtenerTodos();
            return categorias;
        }
        public ResultadoOperacion GuardarCategoria(CategoriaDTO _categoriaDTO)
        {
            CategoriaServicio serv = new CategoriaServicio();
            ResultadoOperacion resultado = serv.GuardarCategoria(_categoriaDTO);
            return resultado;
        }
        public ResultadoOperacion EditarCategoria(CategoriaDTO _categoriaDTO)
        {
            CategoriaServicio serv = new CategoriaServicio();
            ResultadoOperacion resultado = serv.EditarCategoria(_categoriaDTO);
            return resultado;
        }
        public ResultadoOperacion BorrarCategoria(CategoriaDTO _categoriaDTO)
        {
            CategoriaServicio serv = new CategoriaServicio();
            ResultadoOperacion resultado = serv.BorrarCategoria(_categoriaDTO);
            return resultado;
        }
    }
}
