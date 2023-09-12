using LECR2Aulas.Modelo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LECR2Aulas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulaController : ControllerBase
    {
        static List<Aula> aulas = new List<Aula>()
        {
        new Aula { id = 0,aula ="Electricidad"},
        new Aula { id = 1,aula = "Mantenimiento" },
        new Aula { id = 2,aula= "Software" },
        };
        // GET: api/<AulaController>
        [HttpGet]
        public IEnumerable<Aula> Get()
        {
            return aulas;
        }

    }
}