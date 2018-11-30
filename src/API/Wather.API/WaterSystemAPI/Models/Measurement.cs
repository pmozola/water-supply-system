using System;

namespace WaterSystemAPI.Controllers
{
    public class Measurement
    {
        public Measurement()
        {
            Date = DateTime.Now;

            //FOR test only 
            new TimeSpan(0, 0, 0, 1);
        }

        public int ArduinoId  { get; set; }

        public DateTime Date { get; private set; }

        public double Temperature { get; set; }

        public double Humidity { get; set; }

        public double SoilHumidity { get; set; }

        public double? LightIntensity { get; set; }
    }
}