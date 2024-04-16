using Microsoft.Extensions.Primitives;
using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Factory;
using PaymentApiDotnet.Models;
using PaymentApiDotnet.RabbitMq;
using PaymentApiDotnet.RabbitMq.latest;
using PaymentApiDotnet.Repository;
using PaymentApiDotnet.Services.Base;
using System;

namespace PaymentApiDotnet.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IBankFactory _bankFactory;
        private readonly IBinRepository _binRepository;
        //private readonly PaymentEventProducerRabbitmq _paymentEventProducerRabbitmq;
        private readonly IProducerService _producerService;
       
        public PaymentService(IBankFactory bankFactory , IBinRepository binRepository, IProducerService producerService)// PaymentEventProducerRabbitmq paymentEventProducerRabbitmq)
        {

            _bankFactory = bankFactory;
            _binRepository = binRepository;
            _producerService = producerService;
           // _paymentEventProducerRabbitmq = paymentEventProducerRabbitmq;
          
            
        }

   

        public PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto)
        {
           
            var binInfo = _binRepository.GetBankInfosByCardNumber(paymentRequestDto.CardNumber);
            var releatedBankService = _bankFactory.GetBankServiceByPaymentType(binInfo.BankName);
            try
            {
               PaymentResponseDto response =  releatedBankService.ProcessPayment(paymentRequestDto, binInfo);
               if (!response.PaymentStatus)
                {
                    _producerService.SendMessage(paymentRequestDto);
                   /// _paymentEventProducerRabbitmq.SendMessage(paymentRequestDto);
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
