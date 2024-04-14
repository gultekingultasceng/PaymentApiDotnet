using PaymentAPI.Models;
using PaymentApiDotnet.Entities;
using PaymentApiDotnet.Models;
using System.ComponentModel.DataAnnotations;
using static PaymentApiDotnet.Enums.PaymentTypes;

namespace PaymentApiDotnet.Dto
{
    public class PaymentTransactionDto
    {
        public double Amount { get; set; }
        public long OrderId { get; set; }
        public bool PaymentStatus { get; set; }
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ExpDate { get; set; }
        public string Cvc { get; set; }
        public string PaymentType { get; }


        public PaymentTransactionDto(PaymentTransaction paymentTransaction)
        {
            Amount = paymentTransaction.Amount;
            OrderId = paymentTransaction.OrderId;   
            PaymentStatus = paymentTransaction.PaymentStatus;
            CardNumber = paymentTransaction.CardNumber;
            Name = paymentTransaction.Name;
            SurName = paymentTransaction.SurName;   
            ExpDate = paymentTransaction.ExpDate;
            Cvc = paymentTransaction.Cvc;
            PaymentType = paymentTransaction.PaymentType;
            
        }
    }
}
