using System;
using System.Threading.Tasks;
using ServiceBus.Interfaces;
using WaterSystem.Messages;

namespace NotificationCenter.Handlers
{
    public class AlarmingMeasurementNoticedHandler : IIntegrationEventHandler<AlarmingMeasurementNoticedEvent>
    {
        public Task HandleAsync(AlarmingMeasurementNoticedEvent @event)
        {
            return new Task(() => Console.Write(@event.Value));
        }
    }
}
