using RawRabbit;
using ServiceBus.Interfaces;

namespace ServiceBus.RabbitMQ
{
    public class RabbitMqEventBusPublisher : IIntegrationEventBusPublisher
    {
        private readonly IBusClient busClient;

        public RabbitMqEventBusPublisher(IBusClient busClient)
        {
            this.busClient = busClient;
        }

        public void Publish(IIntegrationEvent @event)
        {
            this.busClient.PublishAsync(@event, configuration: cfg =>
            {
                cfg.WithExchange(
                    e =>
                    {
                        e.WithName(@event.GetType().Namespace.ToLower());
                    });
                cfg.WithRoutingKey(@event.GetType().Name.ToLower());
            });
        }
    }
}