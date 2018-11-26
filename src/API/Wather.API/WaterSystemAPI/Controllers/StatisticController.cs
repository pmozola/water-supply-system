using Microsoft.AspNetCore.Mvc;
using WaterSystemAPI.Models;
using WaterSystemAPI.Repository;

namespace WaterSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        public readonly IMeasurementRepository MeasurementRepository;

        public StatisticController(IMeasurementRepository measurementRepository)
        {
            this.MeasurementRepository = measurementRepository;
        }

        [HttpGet]
        public ActionResult<DayMeasurementStatitic> Get(int arduinoId)
        {
            return this.Ok(this.MeasurementRepository.GetStatisticForDay(arduinoId));
        }
    }
}