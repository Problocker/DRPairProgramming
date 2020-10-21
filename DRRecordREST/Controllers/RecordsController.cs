using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using DRRecordREST.StaticList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLIb.model;

namespace DRRecordREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {

        private static RecordList _list = new RecordList();

        // GET: api/<RecordsController>
        [HttpGet]
        public IActionResult GetAllRecords()
        {
            var result = _list.GetAllRecords();

            if (_list == null)
            {
                return NotFound("Ikke plader fundet");
            }

            if (_list.GetAllRecords() != null)
            {
                return Ok(result);
            }
            return NotFound("test");

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
