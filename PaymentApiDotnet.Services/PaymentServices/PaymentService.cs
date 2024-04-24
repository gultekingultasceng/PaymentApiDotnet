using PaymentApiDotnet.Services.Contracts;
using PaymentApiDotnet.Entities.DataTransferObjects;
using PaymentApiDotnet.Services.Factory;
using PaymentApiDotnet.Services.MessageQueue.Rabbitmq;

namespace PaymentApiDotnet.Services.PaymentServices
{
    public class PaymentService : IPaymentService
    {
        private readonly IServiceManager _serviceManager;
        private readonly IBankFactory _bankFactory;
        private readonly IProducerService _producerService;
        public PaymentService(IServiceManager serviceManager , IBankFactory bankFactory, IProducerService producerService)
        {
            _serviceManager = serviceManager;
            _bankFactory = bankFactory;
            _producerService = producerService;
        }

        public PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto)
        {
            var binInfo = _serviceManager.BinService.GetBankInfosByCardNumber(paymentRequestDto.CardNumber);
            var releatedBankService = _bankFactory.GetBankServiceByPaymentType(binInfo.BankName);
            try
            {
                PaymentResponseDto response;
                if (releatedBankService != null)
                {
                     response = releatedBankService.ProcessPayment(paymentRequestDto, binInfo);
                    if (!response.PaymentStatus)
                    {
                        _producerService.SendMessage(paymentRequestDto);
                       
                    }
                    return response;
                }
                throw new Exception("Could not found target Bank Service !");
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
