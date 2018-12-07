using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RawRabbit;
using RawRabbit.Configuration;
using RawRabbit.vNext;

namespace ServiceBus.RabbitMQ
{
    public static class AddRabbitMQExtension
    {
        public static void AddRabbitMq(this IServiceCollection services, IConfigurationSection section)
        {
            var options = new RawRabbitConfiguration();
            options.Hostnames.RemoveAll(x => x.Any());


            section.Bind(options);
            options.Queue.AutoDelete = false;

            var client = BusClientFactory.CreateDefault(options);
            services.AddSingleton<IBusClient>(client);
        }
    }
}