using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mirpaha.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Patzient : ControllerBase
    {
        private static List<Doctor> patzients = new List<Patzient> { new Patzient {Id=1,Health_insurance="Gold", PhoneNumber="052-7612548", Address="Hanevihim 3" },
            new Patzient {Id=2,Health_insurance="Perfect", PhoneNumber="052-7612918", Address="Hamelachim 14" } };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return patzients;
        }

        // GET api/<Patzient>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Patzient>
        [HttpPost]
        public void Post([FromBody] Patzient newPatzient)
        {
            patzients.Add(new Patzient { id = newPatzient.Id health_insurance = newPatzient.Health_insurance, phone = newPatzient.PhoneNumber, address = newPatzient.Address }); ;
        }

        // PUT api/<Patzient>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var e = patzients.FirstOrDefault(e => e.Id == id);
            if (e != null)
            {
                e.Id = id;  e.Health_insurance = health_insurance; e.PhoneNumber = phone; e.Address = address;
            };
        }

        // DELETE api/<Patzient>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var e = patzients.FirstOrDefault(e => e.Id == id);
            if (e != null) { patzients.Remove(e); }
        }
    }
}
