using LECR2Cliente.Modelo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LECR2Cliente.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        static List<Cliente> clientes = new List<Cliente>();

        // GET: api/<AlumnoController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return clientes;
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            var cliente = clientes.FirstOrDefault(x => x.Id == id);
            return cliente;
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            clientes.Add(cliente);
            return Ok();
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Cliente cliente)
        {
            var existingCliente = clientes.FirstOrDefault(x => x.Id == id);
            if (existingCliente != null)
            {
                existingCliente.Name = cliente.Name;
                existingCliente.LastName = cliente.LastName;
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
            var existingCliente = clientes.FirstOrDefault(x => x.Id == id);
            if (existingCliente != null)
            {
                clientes.Remove(existingCliente);
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }
    }
}