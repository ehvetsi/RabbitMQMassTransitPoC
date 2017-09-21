using System;
using Contracts;
using MassTransit;
using MassTransit.Log4NetIntegration.Logging;

namespace TestPublisher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Log4NetLogger.Use();
            var bus = Bus.Factory.CreateUsingRabbitMq(x =>
              x.Host(new Uri("rabbitmq://localhost/"), h =>
              {
              }));
            var busHandle = bus.Start();
            var text = "";

            while (text != "quit")
            {
                Console.Write("Enter a message: ");
                text = Console.ReadLine();

                var message = new SomethingHappenedMessage()
                {
                    What = text,
                    When = DateTime.Now
                };

                var cloudMessage = new CloudMessage()
                {
                    InstanceId = text
                };
                bus.Publish<ICloudMessage>(cloudMessage);
                //bus.Publish<ISomethingHappened>(message);
            }

            busHandle.Stop().Wait();
        }
    }
}