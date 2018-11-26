using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WaterSystemAPI.Hubs;
using WaterSystemAPI.Models;
using WaterSystemAPI.Repository;

namespace WaterSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        private ITemperatureRepository _tempRepository;
        private readonly IHubContext<NotifyHub, ITypedHubClient> _hubContext;

        public TempController(ITemperatureRepository temperatureRepository, IHubContext<NotifyHub, ITypedHubClient> hubContext)
        {
            _tempRepository = temperatureRepository;
            _hubContext = hubContext;
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

            _hubContext.Clients.All.BroadcastMessage(value);
        }

        // GET api/values
        [HttpGet("bydate")]
        public ActionResult<IEnumerable<Temperature>> Get(DateTime date)


        {
            var TemperatureList = _tempRepository.GetTemperatureByDate(date);
            return Ok(TemperatureList);



        }

    }
}
