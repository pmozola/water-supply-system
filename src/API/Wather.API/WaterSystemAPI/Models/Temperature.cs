using System;

namespace WaterSystemAPI.Models
{
    public class Temperature
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double CelciusTemperature { get; set; }
        public int ArduinoId { get; set; }
    }
}