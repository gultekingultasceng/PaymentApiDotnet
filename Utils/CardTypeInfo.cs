using System.Text.RegularExpressions;

namespace PaymentApiDotnet.Utils
{
    public enum CardType
    {
        Unknown = 0,
        MasterCard = 1,
        VISA = 2,
        Amex = 3,
        Discover = 4,
        DinersClub = 5,
        JCB = 6,
        enRoute = 7
    }

    public class CardTypeInfo
    {
        public CardTypeInfo(string regEx, int length, CardType type)
        {
            RegEx = regEx;
            Length = length;
            Type = type;
        }

        public string RegEx { get; set; }
        public int Length { get; set; }
        public CardType Type { get; set; }

        public static CardTypeInfo[] _cardTypeInfo =
    {
        new CardTypeInfo("^(51|52|53|54|55)", 16, CardType.MasterCard),
        new CardTypeInfo("^(4)", 16, CardType.VISA),
        new CardTypeInfo("^(4)", 13, CardType.VISA),
        new CardTypeInfo("^(34|37)", 15, CardType.Amex),
        new CardTypeInfo("^(6011)", 16, CardType.Discover),
        new CardTypeInfo("^(300|301|302|303|304|305|36|38)", 14, CardType.DinersClub),
        new CardTypeInfo("^(3)", 16, CardType.JCB),
        new CardTypeInfo("^(2131|1800)", 15, CardType.JCB),
        new CardTypeInfo("^(2014|2149)", 15, CardType.enRoute),
       };

        public static CardType GetCardType(string cardNumber)
        {
            foreach (CardTypeInfo info in _cardTypeInfo)
            {
                if (cardNumber.Length == info.Length &&
                    Regex.IsMatch(cardNumber, info.RegEx))
                    return info.Type;
            }

            return CardType.Unknown;
        }
    }

    // Array of CardTypeInfo objects.
    // Used by GetCardType() to identify credit card types.
   
}
