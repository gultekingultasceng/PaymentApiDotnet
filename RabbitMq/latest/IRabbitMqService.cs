using RabbitMQ.Client;

namespace PaymentApiDotnet.RabbitMq.latest
{
    public interface IRabbitMqService
    {
        IConnection CreateChannel();
    }
}
