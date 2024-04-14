using System.Text.RegularExpressions;
using PaymentApiDotnet.Enums;
using static PaymentApiDotnet.Enums.PaymentTypes;
namespace PaymentApiDotnet.Utils
{


    public class CardTypeInfo
    {
        public CardTypeInfo(string regEx, int length, PaymentType type)
        {
            RegEx = regEx;
            Length = length;
            Type = type;
        }

        public string RegEx { get; set; }
        public int Length { get; set; }
        public PaymentType Type { get; set; }

        public static CardTypeInfo[] _cardTypeInfo =
    {
        new CardTypeInfo("^(51|52|53|54|55)", 16, PaymentType.MasterCard),
        new CardTypeInfo("^(4)", 16, PaymentType.VISA),
        new CardTypeInfo("^(4)", 13, PaymentType.VISA),
        new CardTypeInfo("^(34|37)", 15, PaymentType.Amex),
        new CardTypeInfo("^(6011)", 16, PaymentType.Discover),
        new CardTypeInfo("^(300|301|302|303|304|305|36|38)", 14, PaymentType.DinersClub),
        new CardTypeInfo("^(3)", 16, PaymentType.JCB),
        new CardTypeInfo("^(2131|1800)", 15, PaymentType.JCB),
        new CardTypeInfo("^(2014|2149)", 15, PaymentType.enRoute),
       };

        public static PaymentType GetCardType(string cardNumber)
        {
            foreach (CardTypeInfo info in _cardTypeInfo)
            {
                if (cardNumber.Length == info.Length &&
                    Regex.IsMatch(cardNumber, info.RegEx))
                    return info.Type;
            }

            return PaymentType.Unknown;
        }
    }

    // Array of CardTypeInfo objects.
    // Used by GetCardType() to identify credit card types.
   
}
