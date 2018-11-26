using System;
using System.Collections.Generic;

using WaterSystemAPI.Models;

namespace WaterSystemAPI.Repository
{
    public interface ITemperatureRepository
    {
        void Add(Temperature temperature);

        Temperature Get(int id);

        List<Temperature> GetAll();

        List<Temperature> GetTemperatureByDate(DateTime date);
    }
}