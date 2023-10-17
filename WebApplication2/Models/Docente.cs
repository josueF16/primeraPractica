using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication2.Models
{
    public class Docente
    {
        [Key]
        public int idDocente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ubicacion { get; set; }
        public string Sexo { get; set; }
        public string CI { get; set; }
        public int idUniversidad { get; set; }
    }
}