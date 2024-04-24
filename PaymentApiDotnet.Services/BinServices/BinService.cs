using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Repositories.Contracts;
using PaymentApiDotnet.Services.Contracts;


namespace PaymentApiDotnet.Services.BinServices
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
