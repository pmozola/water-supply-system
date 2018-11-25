using System.Collections.Generic;
using System.Linq;
using WaterSystemAPI.Models;

namespace WaterSystemAPI.Repository
{
    public class TemperatureRepository : ITemperatureRepository
    {
        public TemperatureRepository()
        {
            _temperatureList = new List<Temperature>();
        }

        private readonly List<Temperature> _temperatureList;

        public void Add(Temperature temperature)

        {
            _temperatureList.Add(temperature);
        }

        public Temperature Get (int id)

        {
         return   _temperatureList.FirstOrDefault(x => x.Id == id);
        }


    }

    public interface ITemperatureRepository
    {
        void Add(Temperature temperature);

        Temperature Get(int id);
    }
}
