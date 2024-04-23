using RabbitMQ.Client;

namespace PaymentApiDotnet.RabbitMq
{
    public interface IRabbitMqService
    {
        IConnection CreateChannel();
    }
}
