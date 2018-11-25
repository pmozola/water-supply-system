using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterSystemAPI.Models;
using WaterSystemAPI.Repository;

namespace WaterSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        private ITemperatureRepository _tempRepository;

        public TempController(ITemperatureRepository temperatureRepository)
        {
            _tempRepository = temperatureRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Temperature>> Get()

        {
            var TemperatureList = _tempRepository.GetAll();
            return Ok(TemperatureList);

            

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var temp = _tempRepository.Get(id);

            return Ok(temp);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Temperature value)
        {
            _tempRepository.Add(value);

        }

      
    }
}
