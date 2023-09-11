using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba2eje3.Modelo;

namespace Prueba2eje3.Controllers
{
    public class MateriaController : Controller
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

