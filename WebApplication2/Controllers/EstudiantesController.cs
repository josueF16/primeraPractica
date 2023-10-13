using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudiantesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<EstudiantesController> _logger;                         
        private readonly AplicacionContexto _aplicacionContexto;
        public EstudiantesController(
            ILogger<EstudiantesController> logger, 
            AplicacionContexto aplicacionContexto)
        {   
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Estudiante estudiante)
        {
            _aplicacionContexto.Estudiantes.Add(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public  IEnumerable<Estudiante> Get()
        {
            return _aplicacionContexto.Estudiantes.ToList();
        }
        //Update: Modificar estudiantes
        [Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Estudiante estudiante)
        {
            _aplicacionContexto.Estudiantes.Update(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //Delete: Eliminar estudiantes
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int estudiantesID)
        {
            _aplicacionContexto.Estudiantes.Remove(
                _aplicacionContexto.Estudiantes.ToList()
                .Where(x=>x.IdEstudiante == estudiantesID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges ();

            return Ok(estudiantesID);
        }
    }
}