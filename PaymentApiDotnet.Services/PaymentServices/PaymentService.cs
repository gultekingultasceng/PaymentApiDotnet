using PaymentApiDotnet.Services.Contracts;
using PaymentApiDotnet.Entities.DataTransferObjects;
using PaymentApiDotnet.Services.Factory;
using PaymentApiDotnet.Services.MessageQueue.Rabbitmq;
using PaymentApiDotnet.Services.Logger;
using PaymentApiDotnet.Entities.Exceptions;

namespace PaymentApiDotnet.Services.PaymentServices
{
    public class PaymentService : IPaymentService
    {
        private readonly IServiceManager _serviceManager;
        private readonly IBankFactory _bankFactory;
        private readonly IProducerService _producerService;
        private readonly ILoggerService _loggerService;
        public PaymentService(IServiceManager serviceManager , IBankFactory bankFactory, IProducerService producerService, ILoggerService loggerService)
        {
            _serviceManager = serviceManager;
            _bankFactory = bankFactory;
            _producerService = producerService;
            _loggerService = loggerService;
        }

        public PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto)
        {
            var binInfo = _serviceManager.BinService.GetBankInfosByCardNumber(paymentRequestDto.CardNumber);
            string bankName = binInfo.BankName;
            var releatedBankService = _bankFactory.GetBankServiceByPaymentType(bankName);
            PaymentResponseDto response;
            if (releatedBankService != null)
            {
                response = releatedBankService.ProcessPayment(paymentRequestDto, binInfo);
                if (!response.PaymentStatus)
                {
                    _loggerService.LogWarning($"Something went wrong. Running in the background. {response.PaymentStatus}");
                    _producerService.SendMessage(paymentRequestDto);
                }
                else
                {
                    _loggerService.LogInfo($"Payment is succesfull. Amount :{response.Amount}");
                }
                return response;
            }
            else
            {
                throw new ReleatedBankServiceNotFoundException(bankName);
            }
        }
    }
}
