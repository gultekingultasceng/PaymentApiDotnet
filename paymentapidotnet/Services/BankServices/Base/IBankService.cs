﻿using PaymentApiDemo.Dto;
using PaymentApiDotnet.Dto;
using PaymentApiDotnet.Entities.Models;

namespace PaymentApiDotnet.Services.BankServices.Base
{
    public interface IBankService
    {
         PaymentResponseDto ProcessPayment(PaymentRequestDto paymentRequestDto , Bin binInfo);
    }
}