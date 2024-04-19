using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using PaymentApiDotnet.Dto;
using Newtonsoft.Json;
using PaymentApiDotnet.Services.Base;
using PaymentApiDotnet.Services;

namespace PaymentApiDotnet.RabbitMq.latest
{

    public interface IConsumerService
    {
        Task ReadMessgaes();
    }
    public class ConsumerService : IConsumerService, IDisposable
    {
        const string _queueName = "paymentQueue";
        private readonly IModel _model;
        private readonly IConnection _connection;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public ConsumerService(IRabbitMqService rabbitMqService , IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _connection = rabbitMqService.CreateChannel();
            _model = _connection.CreateModel();
            _model.QueueDeclare(_queueName, durable: true, exclusive: false, autoDelete: false);
            _model.ExchangeDeclare("UserExchange", ExchangeType.Fanout, durable: true, autoDelete: false);
            _model.QueueBind(_queueName, "UserExchange", string.Empty);
        }
       
        public async Task ReadMessgaes()
        {
            var consumer = new AsyncEventingBasicConsumer(_model);
            consumer.Received += async (ch, ea) =>
            {
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    var serviceProvider = scope.ServiceProvider;
                    var paymentService = serviceProvider.GetRequiredService<IPaymentService>();

                    var body = ea.Body.ToArray();
                    var text = System.Text.Encoding.UTF8.GetString(body);
                    var paymentRequestDto = JsonConvert.DeserializeObject<PaymentRequestDto>(text);
                    Console.WriteLine(" [x] Received {0}", text);
                    paymentService.ProcessPayment(paymentRequestDto);

                    Console.WriteLine(text);
                    await Task.CompletedTask;
                    _model.BasicAck(ea.DeliveryTag, false);
                }
            };
            _model.BasicConsume(_queueName, false, consumer);
            await Task.CompletedTask;
        }

        public void Dispose()
        {
            if (_model.IsOpen)
                _model.Close();
            if (_connection.IsOpen)
                _connection.Close();
        }
    }
}
