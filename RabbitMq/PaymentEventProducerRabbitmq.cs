
using PaymentApiDotnet.Dto;
using RabbitMQ.Client;
using Newtonsoft.Json;
using System.Text;
using PaymentApiDotnet.Services.Base;
namespace PaymentApiDotnet.RabbitMq
{
    public class PaymentEventProducerRabbitmq
    {
        private readonly ConnectionFactory _connectionFactory;
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly string _queueName;

        public PaymentEventProducerRabbitmq(string hostName, string queueName)
        {
            _connectionFactory = new ConnectionFactory() { HostName = hostName };
            _connection = _connectionFactory.CreateConnection();
            _channel = _connection.CreateModel();
            _queueName = queueName;
            
        }

        public void SendMessage(PaymentRequestDto paymentRequestDto)
        {
            _channel.QueueDeclare(queue: _queueName,
                             durable: false,
                             exclusive: false,
                             autoDelete: false,
                             arguments: null);
            var message = JsonConvert.SerializeObject(paymentRequestDto);
            var body = System.Text.Encoding.UTF8.GetBytes(message);
            _channel.BasicPublish(exchange: "",
                             routingKey: _queueName,
                             basicProperties: null,
                             body: body);

            Console.WriteLine(" [x] Sent '{0}'", message);
            
        }


    }
}
