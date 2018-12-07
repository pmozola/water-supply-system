using System;
using Microsoft.AspNetCore.Builder;
using RawRabbit;
using ServiceBus.Interfaces;

namespace ServiceBus.RabbitMQ
{
    public static class AddRabbitMQSubscriberExtension
    {
        public static IApplicationBuilder AddHandler<TEvent>(this IApplicationBuilder app, IBusClient client)
            where TEvent : IIntegrationEvent
        {
            if (app.ApplicationServices.GetService(typeof(IIntegrationEventHandler<TEvent>))
                is IIntegrationEventHandler<TEvent> handler)
            {
                client
                    .SubscribeAsync<TEvent>(async (@event, context) =>
                    {
                        try
                        {
                            await handler.HandleAsync(@event);
                        }
                        catch (Exception ex)
                        {
                            // TODO logException and handle error
                            Console.WriteLine(ex);
                        }
                    });

                return app;
            }

            throw new NotImplementedException();
        }

        public static IApplicationBuilder AddHandler<TEvent>(this IApplicationBuilder app)
            where TEvent : IIntegrationEvent
        {
            if (app.ApplicationServices.GetService(typeof(IBusClient)) is IBusClient busClient)
            {
                return AddHandler<TEvent>(app, busClient);
            }

            throw new NullReferenceException();
        }
    }
}