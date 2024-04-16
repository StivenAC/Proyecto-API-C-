using Biblioteca.Api.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Api.DTO
{
    public class LibroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorDTO Autor { get; set; }
    }
}
