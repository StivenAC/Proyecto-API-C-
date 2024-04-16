using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Api.Model
{
    public class Libro
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int AutorId { get; set; }
        [ForeignKey("AutorId")]
        public Autor Autor { get; set; }
    }
}
