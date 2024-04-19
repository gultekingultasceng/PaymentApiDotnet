using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Repositories.Contracts;


namespace PaymentApiDotnet.Services
{
    public class BinService : IBinService
    {
    
        private readonly IRepositoryManager _repositoryManager;

        public BinService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public Bin? GetBankInfosByCardNumber(string cardNumber)
        {
            return _repositoryManager.binRepository.GetBankInfoByCardNumber(cardNumber, true);
        }
    }
}
