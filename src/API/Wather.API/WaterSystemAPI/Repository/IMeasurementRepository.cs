using System.Collections;
using System.Collections.Generic;
using WaterSystemAPI.Controllers;

namespace WaterSystemAPI.Repository
{
    public interface IMeasurementRepository
    {
        void Save(Measurement measurement);

        IEnumerable<Measurement> GetCurrentMeasurement(int arduinoId);
    }
}