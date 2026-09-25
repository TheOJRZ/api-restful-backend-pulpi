using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_restful_backend_pulpi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionesController : ControllerBase
    {
        // GET: api/<TransaccionesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TransaccionesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TransaccionesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TransaccionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TransaccionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
