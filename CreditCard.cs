using CheckDigits.Net.GeneralAlgorithms;
using System;
using PaymentApiDotnet.Utils;
using System.ComponentModel.DataAnnotations;

namespace PaymentApiDotnet
{
    public class CreditCard
    {
        [CreditCard]
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ExpDate { get; set; }
        public string Cvc { get; set; }
        public string PaymentType { get; }

        public CreditCard(string cardNumber, string name, string surName, string expDate, string cvc)
        {
            CardNumber = cardNumber;
            Name = name;
            SurName = surName;
            ExpDate = expDate;
            Cvc = cvc;
            PaymentType = getCardType();
        }

        private string getCardType()
        {
            return CardTypeInfo.GetCardType(CardNumber).ToString();
        }
    }
}

