using RabbitMQ.Client;

namespace PaymentApiDotnet.Services.MessageQueue.Rabbitmq
{
    public interface IRabbitMqService
    {
        IConnection CreateChannel();
    }
}
