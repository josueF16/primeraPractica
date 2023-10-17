using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocenteController : ControllerBase
    {
        private readonly ILogger<DocenteController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public DocenteController(
            ILogger<DocenteController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Docente docente)
        {
            _aplicacionContexto.Docente.Add(docente);
            _aplicacionContexto.SaveChanges();
            return Ok(docente);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]
        public IEnumerable<Docente> Get()
        {
            return _aplicacionContexto.Docente.ToList();
        }
        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Docente docente)
        {
            _aplicacionContexto.Docente.Update(docente);
            _aplicacionContexto.SaveChanges();
            return Ok(docente);
        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int docenteID)
        {
            _aplicacionContexto.Docente.Remove(
                _aplicacionContexto.Docente.ToList()
                .Where(x => x.idDocente == docenteID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();

            return Ok(docenteID);
        }
    }
}