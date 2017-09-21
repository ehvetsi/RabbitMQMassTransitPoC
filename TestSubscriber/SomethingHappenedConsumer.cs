using System;
using System.Threading.Tasks;
using Contracts;
using MassTransit;

namespace TestSubscriber
{
    internal class SomethingHappenedConsumer : IConsumer<ICloudMessage>
    {
        public Task Consume(ConsumeContext<ICloudMessage> context)
        {
            Console.WriteLine("Instance Id: " + context.Message.InstanceId);
            return Task.FromResult(0);
        }
    }
}