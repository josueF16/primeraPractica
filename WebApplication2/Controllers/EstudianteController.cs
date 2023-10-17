using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudianteController : ControllerBase
    {
        private readonly ILogger<EstudianteController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EstudianteController(
            ILogger<EstudianteController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Estudiantes estudiante)
        {
            _aplicacionContexto.Estudiantes.Add(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]
        public IEnumerable<Estudiantes> Get()
        {
            return _aplicacionContexto.Estudiantes.ToList();
        }
        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Estudiantes estudiante)
        {
            _aplicacionContexto.Estudiantes.Update(estudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(estudiante);
        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int estudiantesID)
        {
            _aplicacionContexto.Estudiantes.Remove(
                _aplicacionContexto.Estudiantes.ToList()
                .Where(x => x.idEstudiante == estudiantesID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();

            return Ok(estudiantesID);
        }
    }
}