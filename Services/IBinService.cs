using PaymentApiDotnet.Models;

namespace PaymentApiDotnet.Services
{
    public interface IBinService
    {
        public Bin? GetBankInfosByCardNumber(string cardNumber);
    }
}
