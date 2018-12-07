using System;
using ServiceBus.Interfaces;

namespace ServiceBus.Models
{
    public class IntegrationEvent : IIntegrationEvent
    {
        public IntegrationEvent()
        {
            this.Id = Guid.NewGuid();
            this.OccurredOn = DateTime.Now;
        }

        public Guid Id { get; }

        public DateTime OccurredOn { get; }
    }
}