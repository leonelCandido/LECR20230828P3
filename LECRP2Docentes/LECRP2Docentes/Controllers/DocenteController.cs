using LECRP2Docentes.Modelo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LECRP2Docentes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        static List<Docente> docentes = new List<Docente>();


        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public Docente Get(int id)
        {
            var docente = docentes.FirstOrDefault(x => x.Id == id);
            return docente;
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public IActionResult Post([FromBody] Docente docente)
        {
            docentes.Add(docente);
            return Ok();
        }

    }
}
