using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Sercan Güler";
        }

        // POST: api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/values/5
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
