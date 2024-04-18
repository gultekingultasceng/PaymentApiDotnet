
using PaymentApiDotnet.Models;
using System.ComponentModel.DataAnnotations;

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
        public string BankName { get; }
        public string CardType { get; }

        public int BankCode { get; set; }

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
            BankName = paymentTransaction.BankName;
            CardType = paymentTransaction.CardType;
            BankCode = paymentTransaction.BankCode;


        }
    }
}
