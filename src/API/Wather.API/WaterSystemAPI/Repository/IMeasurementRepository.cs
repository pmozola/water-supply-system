using System.Collections.Generic;

using WaterSystemAPI.Controllers;
using WaterSystemAPI.Models;

namespace WaterSystemAPI.Repository
{
    public interface IMeasurementRepository
    {
        void Save(Measurement measurement);

        IEnumerable<Measurement> GetCurrentMeasurement(int arduinoId);

        DayMeasurementStatitic GetStatisticForDay(int arduinoId);
    }
}