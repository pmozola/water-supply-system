using System;

namespace WaterSystemAPI.Controllers
{
    public class Measurement
    {
        public Measurement()
        {
            Date = DateTime.Now;
        }

        public int ArduinoId  { get; set; }

        public DateTime Date { get; private set; }

        public double Temperature { get; set; }

        public double Humidity { get; set; }

        public double SoilHumidity { get; set; }

        public double? LightIntensity { get; set; }
    }
}