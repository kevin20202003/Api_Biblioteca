using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Api_Biblioteca.Model
{
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_autor { get; set; }
        public Libro Libro { get; set; }
        public string? Nombre { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem> Libros { get; set; }
    }
}
