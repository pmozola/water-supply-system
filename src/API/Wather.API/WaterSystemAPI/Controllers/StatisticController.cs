using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using WaterSystemAPI.Models;
using WaterSystemAPI.Repository;

namespace WaterSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {

        public StatisticController(ITemperatureRepository temperatureRepository)
        {
        }

        // GET api/statistic/day
        [HttpGet("day")]
        public ActionResult<IEnumerable<Temperature>> Get(DateTime? date)
        {
            return this.Ok();
        }
    }
}