using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MateriaController : ControllerBase
    {
        private readonly ILogger<MateriaController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public MateriaController(
            ILogger<MateriaController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Materia materia)
        {
            _aplicacionContexto.Materia.Add(materia);
            _aplicacionContexto.SaveChanges();
            return Ok(materia);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]
        public IEnumerable<Materia> Get()
        {
            return _aplicacionContexto.Materia.ToList();
        }
        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Materia materia)
        {
            _aplicacionContexto.Materia.Update(materia);
            _aplicacionContexto.SaveChanges();
            return Ok(materia);
        }
        //Delete: Eliminar estudiantes
        // [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int materiaID)
        {
            _aplicacionContexto.Materia.Remove(
                _aplicacionContexto.Materia.ToList()
                .Where(x => x.idMateria == materiaID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();

            return Ok(materiaID);
        }
    }
}