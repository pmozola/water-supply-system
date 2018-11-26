using System;
using System.Collections.Generic;
using System.Linq;

using WaterSystemAPI.Controllers;
using WaterSystemAPI.Models;

namespace WaterSystemAPI.Repository
{
    public class FakeMeasurementRepository : IMeasurementRepository
    {
        public FakeMeasurementRepository()
        {
            this.database = new List<Measurement>();
        }

        private readonly IList<Measurement> database;

        public void Save(Measurement measurement)
        {
            this.database.Add(measurement);
        }

        public IEnumerable<Measurement> GetCurrentMeasurement(int arduinoId)
        {
            throw new System.NotImplementedException();
        }

        public DayMeasurementStatitic GetStatisticForDay(int arduinoId)
        {
            var measurementForArduino = this.database
                .Where(x => 
                    x.ArduinoId == arduinoId 
                    && x.Date.Date == DateTime.Now.Date)
                .ToList();

            return new DayMeasurementStatitic()
            {
                DayTemperatureStatistic = new DayStatistic
                {
                    Max = measurementForArduino.Max(x => (double?)x.Temperature),
                    Min = measurementForArduino.Min(x => (double?)x.Temperature),
                    Average = measurementForArduino.Average(x => (double?)x.Temperature)
                },
                DayHumidityStatistic = new DayStatistic
                {
                    Max = measurementForArduino.Max(x => (double?)x.Humidity),
                    Min = measurementForArduino.Min(x => (double?)x.Humidity),
                    Average = measurementForArduino.Average(x => (double?)x.Humidity)
                },
                DaySoilHumidityStatistic = new DayStatistic
                {
                    Max = measurementForArduino.Max(x => (double?)x.SoilHumidity),
                    Min = measurementForArduino.Min(x => (double?)x.SoilHumidity),
                    Average = measurementForArduino.Average(x => (double?)x.SoilHumidity)
                },
                DayLightIntensityStatistic = new DayStatistic
                {
                    Max = measurementForArduino.Max(x => x.LightIntensity),
                    Min = measurementForArduino.Min(x => x.LightIntensity),
                    Average = measurementForArduino.Average(x => x.LightIntensity)
                }
            };
        }
    }
}