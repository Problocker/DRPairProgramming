using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLIb.model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRRecordREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private static readonly List<Record> records = new List<Record>()
        {
            new Record("Guld", "Mikkel", 200, "2019", "Danmark", true),
            new Record("Min Lille Mand", "Carl Gustaf Larson", 459, "1910", "Sverigestan", false),
            new Record("Store Peter Raketbygger", "Peter Madsen", 300, "2017", "Danmark",true),
            new Record("99 Luftballons", "NENA", 253, "2000", "Deutschland",true),
            new Record("I Want It That Way", "BackStreet Boys", 213, "1999", "England",true)

        };

        // GET: api/<RecordsController>
        [HttpGet]
        public IEnumerable<Record> Get()
        {
            return records;

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
