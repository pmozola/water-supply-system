using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterSystemAPI.Models;

namespace WaterSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "trhftrjf", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Temperature temp = new Temperature();
            
            return Ok(temp);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Temperature value)
        {
        }

      
    }
}
