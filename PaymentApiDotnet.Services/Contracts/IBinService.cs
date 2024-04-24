using PaymentApiDotnet.Entities.Models;

namespace PaymentApiDotnet.Services.Contracts
{
    public interface IBinService
    {
        public Bin? GetBankInfosByCardNumber(string cardNumber);
    }
}
