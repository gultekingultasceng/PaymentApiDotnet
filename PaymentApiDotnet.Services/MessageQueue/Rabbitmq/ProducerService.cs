using Newtonsoft.Json;
using PaymentApiDotnet.Entities.DataTransferObjects;
using RabbitMQ.Client;
using System.Text;

namespace PaymentApiDotnet.Services.MessageQueue.Rabbitmq
{
    public interface IProducerService
    {
        void SendMessage(PaymentRequestDto paymentRequestDto);
    }
    public class ProducerService : IProducerService
    {
        const string _queueName = "paymentQueue";
        private readonly IModel _model;
        private readonly IConnection _connection;

        public ProducerService(IRabbitMqService rabbitMqService)
        {
            _connection = rabbitMqService.CreateChannel();
            _model = _connection.CreateModel();
            _model.QueueDeclare(_queueName, durable: true, exclusive: false, autoDelete: false);
            _model.ExchangeDeclare("UserExchange", ExchangeType.Fanout, durable: true, autoDelete: false);
            _model.QueueBind(_queueName, "UserExchange", string.Empty);
        }
        public void SendMessage(PaymentRequestDto paymentRequestDto)
        {
            var message = JsonConvert.SerializeObject(paymentRequestDto);
            var body = Encoding.UTF8.GetBytes(message);
            Console.WriteLine(" [x] Sent '{0}'", message);
            _model.BasicPublish("UserExchange",
                                 string.Empty,
                                 basicProperties: null,
                                 body: body);
        }
    }
}
