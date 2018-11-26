using System;
using System.Collections.Generic;
using System.Linq;

using WaterSystemAPI.Models;

namespace WaterSystemAPI.Repository
{
    public class TemperatureRepository : ITemperatureRepository
    {
        public TemperatureRepository()
        {
            // Some fake data
            _temperatureList = new List<Temperature>
            {
                new Temperature
                {
                    ArduinoId = 1,
                    Date = new DateTime(1988, 12, 28),
                    CelciusTemperature = 23,
                    Id = 1
                },
                new Temperature
                {
                    ArduinoId = 1,
                    Date = new DateTime(1993, 11, 13),
                    CelciusTemperature = 42,
                    Id = 2
                },
                new Temperature
                {
                    ArduinoId = 1,
                    Date = new DateTime(2004, 5, 25),
                    CelciusTemperature = 12,
                    Id = 3
                },
                new Temperature
                {
                    ArduinoId = 1,
                    Date = new DateTime(2004, 8, 25),
                    CelciusTemperature = 1589,
                    Id = 4
                }
            };
        }
    

        private readonly List<Temperature> _temperatureList;

        public void Add(Temperature temperature)
        {
            _temperatureList.Add(temperature);
        }

        public Temperature Get(int id)
        {
            return _temperatureList.FirstOrDefault(x => x.Id == id);
        }

        public List<Temperature> GetAll()
        {
            return _temperatureList;
        }

        public List<Temperature> GetTemperatureByDate(DateTime date)
        {
            return _temperatureList.Where(x => x.Date.Date == date.Date).ToList();
        }
    }
}