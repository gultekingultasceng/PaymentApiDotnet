using AutoMapper;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Entities.Models;
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
            _mapper.Map(binInfo, paymentTransaction);
            paymentTransaction.PaymentStatus = paymentStatus;
             _paymentRepository.AddTransaction(paymentTransaction);
        }

        public List<PaymentTransactionDto> GetTransactionsByBankCode(int bankCode)
        {
            List<PaymentTransaction> paymentTransactions =  _paymentRepository.GetTransactionsByBankCode(bankCode);
            List<PaymentTransactionDto> paymentTransactionDtoList = new List<PaymentTransactionDto>();
            foreach (var paymentTransaction in paymentTransactions)
            {
                paymentTransactionDtoList.Add(_mapper.Map<PaymentTransactionDto>(paymentTransaction));
            }
            return paymentTransactionDtoList;
            
        }

    }
}
