using LECRP3RegistroAcademico.Modelo;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace LECRP3RegistroAcademico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    [Authorize]
    public class MatriculaController : ControllerBase
    {
        static List<Matricula> matriculas = new List<Matricula>();

        // GET api/<MatriculaController>/5
        [HttpGet("{id}")]
        public Matricula Get(int id)
        {
            var matricula = matriculas.FirstOrDefault(x => x.Id == id);
            return matricula;
        }

        // POST api/<MatriculaController>
        [HttpPost]
        public IActionResult Post([FromBody] Matricula matricula)
        {
            matriculas.Add(matricula);
            return Ok();
        }

        // PUT api/<MatriculaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Matricula matricula)
        {
            var existingMatricula = matriculas.FirstOrDefault(x => x.Id == id);
            if (existingMatricula != null)
            {
                existingMatricula.Name = matricula.Name;
                existingMatricula.Grado = matricula.Grado;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
