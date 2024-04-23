using Microsoft.Extensions.Primitives;
using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Factory;
using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.RabbitMq;
using PaymentApiDotnet.Services.Base;
using System;

namespace PaymentApiDotnet.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IBankFactory _bankFactory;
        private readonly IBinService _binService;
        private readonly IProducerService _producerService;
       
        public PaymentService(IBankFactory bankFactory , IBinService binService, IProducerService producerService)
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
               PaymentResponseDto response =  releatedBankService.ProcessPayment(paymentRequestDto, binInfo);
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
