using LECRP2Alumnos.Modelo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LECRP2Alumnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        static List<Alumno> alumnos = new List<Alumno>();

        // GET: api/<AlumnoController>
        [HttpGet]
        public IEnumerable<Alumno> Get()
        {
            return alumnos;
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public Alumno Get(int id)
        {
            var alumno = alumnos.FirstOrDefault(x => x.Id == id);
            return alumno;
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public IActionResult Post([FromBody] Alumno alumno)
        {
            alumnos.Add(alumno);
            return Ok();
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Alumno alumno)
        {
            var existingAlumno = alumnos.FirstOrDefault(x => x.Id == id);
            if (existingAlumno != null)
            {
                existingAlumno.Name = alumno.Name;
                existingAlumno.LastName = alumno.LastName;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingAlumno = alumnos.FirstOrDefault(x => x.Id == id);
            if (existingAlumno != null)
            {
                alumnos.Remove(existingAlumno);
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }
    }
}