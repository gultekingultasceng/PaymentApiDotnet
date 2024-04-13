using CheckDigits.Net.GeneralAlgorithms;
using System;
using PaymentApiDotnet.Utils;

namespace PaymentAPI.Models
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string Name {get; set;}
        public string SurName { get; set;}
        public string ExpDate { get; set;}
        public string Cvc {get; set;}
        public string CardType {get;}

        public CreditCard(string cardNumber, string name,string surName,string expDate,string cvc)
        {
            this.CardNumber = cardNumber;
            this.Name = name;
            this.SurName = surName;
            this.ExpDate = expDate;
            this.Cvc = cvc;
            this.CardNumber = getCardType();
        }

        private string getCardType()
        {
            LuhnAlgorithm luhnAlgorithm = new LuhnAlgorithm();
            bool isValid = luhnAlgorithm.Validate(CardNumber);
            if (isValid)
            {
                return CardTypeInfo.GetCardType(CardNumber).ToString();
            }
            else
            {
                return "Invalid Card !";
            }
        }
    }
}

