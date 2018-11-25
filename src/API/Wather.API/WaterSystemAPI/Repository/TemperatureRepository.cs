using System.Collections.Generic;
using System.Linq;
using WaterSystemAPI.Models;

namespace WaterSystemAPI.Repository
{
    public class TemperatureRepository
    {
        private List<Temperature> TemperatureList;

        void Add(Temperature temperature)

        {
            TemperatureList.Add(temperature);
        }

        Temperature Get (int id)

        {
         return   TemperatureList.FirstOrDefault(x => x.Id == id);
        }


    }
}
