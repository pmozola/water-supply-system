namespace WaterSystemAPI.Controllers
{
    public class Measurement
    {
        public int ArduinoId  { get; set; }

        public double Temperature { get; set; }

        public double Humidity { get; set; }

        public double SoilHumidity { get; set; }

        public double LightIntensity { get; set; }
    }
}