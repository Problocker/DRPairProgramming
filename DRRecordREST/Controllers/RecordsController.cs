using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLIb.model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRRecordREST.Controllers
{
    private static readonly List<Records> records = new List<Records>()
   {
       new Records("Guld", "Mikkel", 200, "2019", "Danemark"),
       new Records("Min Lille Mand", "PewDiePie", 459, "1910", "Sverige"),
       new Records("Store Peter", "Peter", 239, "1981", "Danemark"),
       new Records("99 Luftballons", "NENA", 253, "2000", "Deutschland"),
       new Records("I Want It That Way", "BackStreet Boys", 213, "1999", "England")

   };



    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        // GET: api/<RecordsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
