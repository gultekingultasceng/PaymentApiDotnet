using PaymentApiDotnet.Entities.Models;

namespace PaymentApiDotnet.Repositories.Contracts
{
    public interface IBinRepository
    {
        public Bin? GetBankInfoByCardNumber(string cardNumber , bool trackChanges);
    }
}
