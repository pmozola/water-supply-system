using WaterSystemAPI.Controllers;
using WaterSystemAPI.Models;

namespace WaterSystemAPI.Repository
{
    public interface IMeasurementRepository
    {
        void Save(Measurement measurement);

        Measurement GetCurrentMeasurement(int arduinoId);

        DayMeasurementStatitic GetStatisticForDay(int arduinoId);
    }
}