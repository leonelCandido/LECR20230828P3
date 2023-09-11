using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba2eje2.Modelo;

namespace Prueba2eje2.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class DocenteController : Controller
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
