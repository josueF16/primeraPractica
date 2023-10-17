using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Materia
    {
        [Key]
        public int idMateria { get; set; }
        public string Nombre { get; set; }
        public int idDocente { get; set; }

    }
}