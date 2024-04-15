using Microsoft.Extensions.Primitives;
using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Factory;
using PaymentApiDotnet.Models;
using PaymentApiDotnet.Services.Base;
using System;
using static PaymentApiDotnet.Enums.PaymentTypes;

namespace PaymentApiDotnet.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IBankFactory _bankFactory;
        public PaymentService(IBankFactory bankFactory)
        {
            _bankFactory = bankFactory;
        }

        public PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto)
        {
            var releatedBankService = _bankFactory.GetBankServiceByPaymentType((PaymentType)Enum.Parse(typeof(PaymentType), paymentRequestDto.GetPaymentType()));
            return releatedBankService.ProcessPayment(paymentRequestDto);
        }
    }
}
