using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication2.Models
{
    public class Universidad
    {
        [Key]
        public int idUniversidad { get; set; }
        public string Nombre { get; set; }
    }
}