using CheckDigits.Net.GeneralAlgorithms;
using System;
using PaymentApiDotnet.Utils;
using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class CreditCard
    {
        [CreditCard]
        public string CardNumber { get; set; }
        public string Name {get; set;}
        public string SurName { get; set;}
        public string ExpDate { get; set;}
        public string Cvc {get; set;}
        public string PaymentType {get;}

        public CreditCard(string cardNumber, string name,string surName,string expDate,string cvc)
        {
            this.CardNumber = cardNumber;
            this.Name = name;
            this.SurName = surName;
            this.ExpDate = expDate;
            this.Cvc = cvc;
            this.PaymentType = getCardType();
        }

        private string getCardType()
        {
             return CardTypeInfo.GetCardType(CardNumber).ToString();
        }
    }
}

