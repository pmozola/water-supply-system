using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WaterSystemAPI.Hubs;
using WaterSystemAPI.Repository;

namespace WaterSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurementRepository repository;
        private readonly IHubContext<NotifyHub, ITypedHubClient> hubContext;

        public MeasurementController(
            IMeasurementRepository repository,
            IHubContext<NotifyHub, ITypedHubClient> hubContext)
        {
            this.repository = repository;
            this.hubContext = hubContext;
        }

        [HttpPost]
        public void Post([FromBody] Measurement value)
        {
            this.repository.Save(value);

            this.hubContext.Clients.All.BroadcastMessage(value);
        }

        [HttpGet("latest/{arduinoId:int}")]
        public ActionResult<IEnumerable<Measurement>> Get(int arduinoId)
        {
            return this.Ok(this.repository.GetCurrentMeasurement(arduinoId));
        }
    }
}