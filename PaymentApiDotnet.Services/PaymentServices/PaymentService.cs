using Microsoft.Extensions.Primitives;
using PaymentApiDotnet.Factory;
using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.RabbitMq;
using System;
using PaymentApiDotnet.Services.Contracts;
using PaymentApiDotnet.Entities.DataTransferObjects;

namespace PaymentApiDotnet.Services.PaymentServices
{
    public class PaymentService : IPaymentService
    {
        private readonly IBankFactory _bankFactory;
        private readonly IBinService _binService;
        private readonly IProducerService _producerService;

        public PaymentService(IBankFactory bankFactory, IBinService binService, IProducerService producerService)
        {

            _bankFactory = bankFactory;
            _binService = binService;
            _producerService = producerService;
        }

        public PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto)
        {
            var binInfo = _binService.GetBankInfosByCardNumber(paymentRequestDto.CardNumber);
            var releatedBankService = _bankFactory.GetBankServiceByPaymentType(binInfo.BankName);
            try
            {
                PaymentResponseDto response = releatedBankService.ProcessPayment(paymentRequestDto, binInfo);
                if (!response.PaymentStatus)
                {
                    _producerService.SendMessage(paymentRequestDto);
                }
                return response;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
