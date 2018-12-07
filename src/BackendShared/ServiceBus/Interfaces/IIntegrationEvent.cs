using System;

// TODO move to shared kernel ?
namespace ServiceBus.Interfaces
{
    public interface IIntegrationEvent
    {
        Guid Id { get; }

        DateTime OccurredOn { get; }
    }
}