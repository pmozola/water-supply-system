using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WaterSystemAPI.Controllers;
using WaterSystemAPI.Models;

namespace WaterSystemAPI.Repository
{
    public class FakeMeasurementRepository : IMeasurementRepository
    {
        public FakeMeasurementRepository()
        {
            this.database = PrepareFakeData();
        }

        private readonly IList<Measurement> database;

        public void Save(Measurement measurement)
        {
            this.database.Add(measurement);
        }

        public Measurement GetCurrentMeasurement(int arduinoId)
        {
            return this.database
                .Where(x => x.ArduinoId == arduinoId)
                .OrderByDescending(x => x.Date)
                .FirstOrDefault();
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

        public List<Measurement> GetLogForDay(int arduinoId, DateTime day)
        {
            return this.database
                .Where(x => x.ArduinoId == arduinoId && x.Date.Date == day.Date)
                .ToList();
        }

        private static List<Measurement> PrepareFakeData()
        {
            return  new List<Measurement>
            {
                // arduino1
                new Measurement {ArduinoId = 1, Temperature = 4, Humidity = 14, SoilHumidity = 13, LightIntensity = 123 },
                new Measurement {ArduinoId = 1, Temperature = 5, Humidity = 24, SoilHumidity = 13, LightIntensity = 123 },
                new Measurement {ArduinoId = 1, Temperature = 6, Humidity = 34, SoilHumidity = 13, LightIntensity = 123 },
                new Measurement {ArduinoId = 1, Temperature = 7, Humidity = 54, SoilHumidity = 13, LightIntensity = 123 },
                new Measurement {ArduinoId = 1, Temperature = 12, Humidity = 64, SoilHumidity = 13, LightIntensity = 123 },

                // arduino2
                new Measurement {ArduinoId = 2, Temperature = 23, Humidity = 7, SoilHumidity = 3, LightIntensity = 23 },
                new Measurement {ArduinoId = 2, Temperature = 21, Humidity = 45, SoilHumidity = 3, LightIntensity = 23 },
                new Measurement {ArduinoId = 2, Temperature = 13, Humidity = 33, SoilHumidity = 3, LightIntensity = 23 },
                new Measurement {ArduinoId = 2, Temperature = 2, Humidity = 33, SoilHumidity = 3, LightIntensity = 23 },
            new Measurement {ArduinoId = 2, Temperature = 5 , Humidity = 53, SoilHumidity = 3, LightIntensity = 23 }
            };
        }
    }
}