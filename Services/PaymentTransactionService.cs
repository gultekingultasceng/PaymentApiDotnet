using AutoMapper;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Models;
using PaymentApiDotnet.Repository;
using System;

namespace PaymentApiDotnet.Services
{
    public class PaymentTransactionService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public PaymentTransactionService(IPaymentRepository paymentRepository , IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }
        public void CreatePaymentTransactionFromPaymentRequest(PaymentRequestDto paymentRequestDto ,Bin binInfo, bool paymentStatus)
        {
            PaymentTransaction paymentTransaction = _mapper.Map<PaymentTransaction>(paymentRequestDto);
            paymentTransaction.PaymentStatus = paymentStatus;
            paymentTransaction.BankName = binInfo.BankName;
            paymentTransaction.CardType = binInfo.CardType;
             _paymentRepository.AddTransaction(paymentTransaction);
        }
    }
}
