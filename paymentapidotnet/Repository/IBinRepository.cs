using PaymentApiDotnet.Entities.Models;

namespace PaymentApiDotnet.Repository
{
    public interface IBinRepository
    {
        public Bin GetBankInfosByCardNumber(string cardNumber);
    }
}
