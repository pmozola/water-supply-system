using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WaterSystemAPI.Controllers;

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
    }
}