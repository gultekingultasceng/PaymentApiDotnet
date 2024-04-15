using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Models;
using PaymentApiDotnet.Repository;
using System;

namespace PaymentApiDotnet.Services
{
    public class PaymentTransactionService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentTransactionService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        public void CreatePaymentTransactionFromPaymentRequest(PaymentRequestDto paymentRequestDto , bool paymentStatus)
        {
            PaymentTransaction paymentTransaction = new PaymentTransaction();
            paymentTransaction.Amount = paymentRequestDto.Amount;
            paymentTransaction.CardNumber = paymentRequestDto.CardNumber;
            paymentTransaction.OrderId = paymentRequestDto.OrderId;
            paymentTransaction.Cvc = paymentRequestDto.Cvc;
            paymentTransaction.Name = paymentRequestDto.Name;
            paymentTransaction.SurName = paymentRequestDto.Surname;
            paymentTransaction.ExpDate = paymentRequestDto.ExpDate;
            paymentTransaction.PaymentType = paymentRequestDto.GetPaymentType();
            paymentTransaction.PaymentStatus = paymentStatus;

            _paymentRepository.AddTransaction(paymentTransaction);
           
        }
    }
}
