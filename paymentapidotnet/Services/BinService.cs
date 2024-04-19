using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Repository;

namespace PaymentApiDotnet.Services
{
    public class BinService : IBinService
    {
        private readonly IBinRepository _binRepository;

        public BinService(IBinRepository binRepository)
        {
            _binRepository = binRepository;
        }

        public Bin? GetBankInfosByCardNumber(string cardNumber)
        {
            return _binRepository.GetBankInfosByCardNumber(cardNumber);
        }
    }
}
