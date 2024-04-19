﻿using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Services.BankServices.Base;

namespace PaymentApiDotnet.Services.BankServices
{
    public class AkbankService : BankServiceBase
    {
        public AkbankService(PaymentTransactionService transactionService) : base(transactionService)
        {

        }

        public override void AfterPayment()
        {
           // AKBANK
        }
    }
}
