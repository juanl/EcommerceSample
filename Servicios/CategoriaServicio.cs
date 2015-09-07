using Dominio.Entidades;
using Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class CategoriaServicio : ICategoriaServicio
    {
        ProductoContext _context = new ProductoContext();
        public IList<DTOs.CategoriaDTO> ObtenerPorDescripcion(string cadena)
        {
            var listaCategorias = _context.Categorias.Where(x => x.Descripcion.Contains(cadena))
                .Select(c => new CategoriaDTO
                {
                    CategoriaID = c.CategoriaID,
                    CategoriaNombre = c.CategoriaNombre,
                    Descripcion = c.Descripcion
                }).ToList();
            return listaCategorias;
        }

        public DTOs.CategoriaDTO ObtenerPorId(int categoriaId)
        {
            var categoria = _context.Categorias.Where(x => x.CategoriaID == categoriaId)
                .Select(c => new CategoriaDTO
                {
                    CategoriaID = c.CategoriaID,
                    CategoriaNombre = c.CategoriaNombre,
                    Descripcion = c.Descripcion
                }).FirstOrDefault();
            return categoria;
        }

        public IList<DTOs.CategoriaDTO> ObtenerTodos()
        {
            var listaCategorias = _context.Categorias
                  .Select(c => new CategoriaDTO
                  {
                      CategoriaID = c.CategoriaID,
                      CategoriaNombre = c.CategoriaNombre,
                      Descripcion = c.Descripcion
                  }).ToList();
            return listaCategorias;
        }
        public Categoria ConvertirDesdeDTO(CategoriaDTO _categoriaDTO)
        {
            var categoria = new Categoria()
            {
                CategoriaID = _categoriaDTO.CategoriaID,
                CategoriaNombre = _categoriaDTO.CategoriaNombre,
                Descripcion = _categoriaDTO.Descripcion
            };
            return categoria;
        }

        public ResultadoOperacion GuardarCategoria(DTOs.CategoriaDTO _categoriaDTO)
        {
            ResultadoOperacion res = new ResultadoOperacion();
            try
            {
                var categoria = ConvertirDesdeDTO(_categoriaDTO);
                _context.Categorias.Add(categoria);
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

        public ResultadoOperacion BorrarCategoria(DTOs.CategoriaDTO _categoriaDTO)
        {
            ResultadoOperacion res = new ResultadoOperacion();
            try
            {
                var categoria = ConvertirDesdeDTO(_categoriaDTO);
                _context.Categorias.Remove(categoria);
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
        public ResultadoOperacion EditarCategoria(DTOs.CategoriaDTO _categoriaDTO)
        {
            ResultadoOperacion res = new ResultadoOperacion();
            try
            {
                var categoria = ConvertirDesdeDTO(_categoriaDTO);
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
    }
}
