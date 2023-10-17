using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication2.Models
{
    public class Estudiantes
    {
        [Key]
        public int idEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Sexo { get; set; }
        public int idUniversidad { get; set; }
    }
}