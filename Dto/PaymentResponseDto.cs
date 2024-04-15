using System;
using PaymentApiDotnet;
namespace PaymentApiDemo.Dto
{
    public class PaymentResponseDto
    {
        public double Amount { get; set; }
        public long OrderId { get; set; }
        public bool PaymentStatus { get; }

        public PaymentResponseDto(PaymentInfo paymentInfo)
        {
            Amount = paymentInfo.Amount;
            OrderId = paymentInfo.OrderId;
            PaymentStatus = paymentInfo.GetPaymentStatus();
        }
    }
}
