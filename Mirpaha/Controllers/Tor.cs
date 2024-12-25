using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mirpaha.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Tor : ControllerBase
    {
        // GET: api/<Tor>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Tor>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Tor>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Tor>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Tor>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
