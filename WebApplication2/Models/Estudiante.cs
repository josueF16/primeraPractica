using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string ubicacion { get; set; }
        public string Apellido { get; set; }
    }
}