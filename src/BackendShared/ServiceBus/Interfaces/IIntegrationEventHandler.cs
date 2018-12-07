using System.Threading.Tasks;

namespace ServiceBus.Interfaces
{
    public interface IIntegrationEventHandler<in TEvent>
        where TEvent : IIntegrationEvent
    {
        Task HandleAsync(TEvent @event);
    }
}