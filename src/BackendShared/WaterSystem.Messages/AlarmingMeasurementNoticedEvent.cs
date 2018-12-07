using ServiceBus.Interfaces;
using ServiceBus.Models;

namespace WaterSystem.Messages
{
    public class AlarmingMeasurementNoticedEvent : IntegrationEvent
    {
        public int ArduinoId { get; set; }

        public double Value { get; set; }
    }
}
