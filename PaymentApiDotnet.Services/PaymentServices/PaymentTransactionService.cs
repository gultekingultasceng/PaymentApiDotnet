﻿using AutoMapper;
using PaymentApiDotnet.Entities.DataTransferObjects;
using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Repositories.Contracts;
using PaymentApiDotnet.Services.Contracts;

namespace PaymentApiDotnet.Services.PaymentServices
{
    public class PaymentTransactionService : IPaymentTransactionService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public PaymentTransactionService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public void CreatePaymentTransactionFromPaymentRequest(PaymentRequestDto paymentRequestDto, Bin binInfo, bool paymentStatus)
        {
            PaymentTransaction paymentTransaction = _mapper.Map<PaymentTransaction>(paymentRequestDto);
            _mapper.Map(binInfo, paymentTransaction);
            paymentTransaction.PaymentStatus = paymentStatus;
            _repositoryManager.PaymentRepository.AddTransaction(paymentTransaction);
            _repositoryManager.Save();
        }

        public IEnumerable<PaymentTransactionDto> GetTransactionsByBankCode(int bankCode)
        {
            List<PaymentTransaction> paymentTransactions = _repositoryManager.PaymentRepository.
                GetPaymentTransactionsByBankCode(bankCode, true).ToList();
            List<PaymentTransactionDto> paymentTransactionDtoList = new List<PaymentTransactionDto>();
            foreach (var paymentTransaction in paymentTransactions)
            {
                paymentTransactionDtoList.Add(_mapper.Map<PaymentTransactionDto>(paymentTransaction));
            }
            return paymentTransactionDtoList;

        }

    }
}
