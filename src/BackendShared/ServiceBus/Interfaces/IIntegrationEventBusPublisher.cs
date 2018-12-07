namespace ServiceBus.Interfaces
{
    public interface IIntegrationEventBusPublisher
    {
        void Publish(IIntegrationEvent @event);
    }
}