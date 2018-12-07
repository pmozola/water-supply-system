using System;
using ServiceBus.Interfaces;

namespace ServiceBus
{
    public class FakeIntegrationEventBus : IIntegrationEventBusPublisher
    {
        public void Publish(IIntegrationEvent @event)
        {
            Console.Write(@event);
        }
    }
}