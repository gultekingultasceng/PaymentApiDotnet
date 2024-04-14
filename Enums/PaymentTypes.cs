namespace PaymentApiDotnet.Enums
{
    public class PaymentTypes
    {
        public enum PaymentType
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
    }
}
