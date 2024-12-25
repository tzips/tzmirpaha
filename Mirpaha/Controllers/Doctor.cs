using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mirpaha.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Doctor : ControllerBase
    {//גישה דרך datacontex. 
        //private static List<Doctor> doctors = new List<Doctor> { new Doctor {Id=1,Duty="children", phoneNumber="052-7612548", address="Hanevihim 3",List<dates(DateTime)> schedual=Sunday,8:00,15:00,wednesday'8:00',13:00 },
        //new Doctor {Id=1,Duty="eyes", phoneNumber="052-7612918", address="Hamelachim 14",List<dates(DateTime)> schedual=Monday,12:00,17:30,wednesday'8:00',14:00 } };


        // GET: api/<Doctor>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return DataContext.doctors;
        }

        // GET api/<Doctor>/5
        [HttpGet("{id}")]
        //public <Doctor> Get(int id)//??????
        //{
        //    return doctors.;
        //}

        // POST api/<Doctor>
        [HttpPost]
        public void Post([FromBody] Doctor newDoctor)
        {
            DataContext.doctors.Add(new Doctor { Id = newDoctor.Id, newDoctor.Duty = duty; newDoctor.Phone = phoneNumber; newDoctor.Address = address; });
        }

        // PUT api/<Doctor>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]String duty,String phoneNumber, String address,List<TimeOnly> schedual )
        {
            var e = DataContext.doctors.FirstOrDefault(e => e.Id == id);
            if (e != null) { e.Duty = duty; e.Phone = phoneNumber; e.Address = address; }

        }

        // DELETE api/<Doctor>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var e = DataContext.doctors.FirstOrDefault(e => e.Id == id);
            if (e != null) { DataContext.doctors.Remove(e); }

        }
    }
}
