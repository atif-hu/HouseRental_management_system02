using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseRental_management_system02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordController : ControllerBase
    {
        // GET: api/<LandlordController>
        [HttpGet]
        public IActionResult GetLandlords()
        {
            List<Landlord> ll = LandlordDB.GetLandlords();
            return Ok(ll);
        }

        // GET api/<LandlordController>/5
        [HttpGet("{id}")]
        public IActionResult GetLandlords(int id)
        {
            List<Landlord> ll = LandlordDB.GetLandlords();
            return Ok(ll[id]);

        }

        // POST api/<LandlordController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LandlordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LandlordController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
