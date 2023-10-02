using LECRP3RegistroAcademico.Modelo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LECRP3RegistroAcademico.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        static List<Nota> notas = new List<Nota>();

        // GET: api/<NotaController>
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Nota> Get()
        {
            return notas;
        }


        // POST api/<NotaController>
        [HttpPost]
        public IActionResult Post([FromBody] Nota nota)
        {
            notas.Add(nota);
            return Ok();
        }
    }
}
