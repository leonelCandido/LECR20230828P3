using LECR2Materias.Modelo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LECR2Materias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        static List<Materia> materias = new List<Materia>();

        // GET: api/<AlumnoController>
        [HttpGet]
        public IEnumerable<Materia> Get()
        {
            return materias;
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public IActionResult Post([FromBody] Materia materia)
        {
            materias.Add(materia);
            return Ok();
        }


        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingMateria = materias.FirstOrDefault(x => x.Id == id);
            if (existingMateria != null)
            {
                materias.Remove(existingMateria);
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }
    }
}

