using System;

namespace PaymentAPI.Models
{
    public class CardOwner
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public CreditCard CreditCard { get; set; }

        public CardOwner(string name, string surname, CreditCard creditCard)
        {
            this.Name = name;
            this.SurName = surname;
            this.CreditCard = creditCard;
        }
     
    }
}



