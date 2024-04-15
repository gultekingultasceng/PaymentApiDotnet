using Microsoft.Extensions.Primitives;
using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Factory;
using PaymentApiDotnet.Models;
using PaymentApiDotnet.Repository;
using PaymentApiDotnet.Services.Base;
using System;

namespace PaymentApiDotnet.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IBankFactory _bankFactory;
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IBankFactory bankFactory , IPaymentRepository paymentRepository)
        {
            _bankFactory = bankFactory;
            _paymentRepository = paymentRepository;
        }

   

        public PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto)
        {
              var binInfo =  _paymentRepository.GetBankInfosByCardNumber(paymentRequestDto.CardNumber);
            var releatedBankService = _bankFactory.GetBankServiceByPaymentType(binInfo.BankName);
            return releatedBankService.ProcessPayment(paymentRequestDto, binInfo);
        }
    }
}
