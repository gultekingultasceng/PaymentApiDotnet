using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using Newtonsoft.Json;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Services.Base;
using System.Threading.Channels;
using MongoDB.Driver.Core.Bindings;
using PaymentApiDotnet.Services;
namespace PaymentApiDotnet.RabbitMq
{
    public class PaymentEventConsumerRabbitmq
    {
        private readonly ConnectionFactory _connectionFactory;
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly string _queueName;
        private readonly string _hostName;
        

        public PaymentEventConsumerRabbitmq(string hostName, string queueName)
        {
            _queueName = queueName;
            _hostName = hostName;
            _connectionFactory = new ConnectionFactory() { HostName = _hostName };
            _connection = _connectionFactory.CreateConnection();
            _channel = _connection.CreateModel();
        }
        
        public void StartListening()
        {

            
            _channel.QueueDeclare(queue: _queueName,
                            durable: false,
                            exclusive: false,
                            autoDelete: false,
            arguments: null);

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var message = System.Text.Encoding.UTF8.GetString(body);
                var paymentRequestDto = JsonConvert.DeserializeObject<PaymentRequestDto>(message);
                Console.WriteLine(" [x] Received {0}", paymentRequestDto);

            };

            _channel.BasicConsume(
                            _queueName,
                            true,
                            consumer);
          



        }
    }
}
