using PaymentApiDotnet.Context;
using PaymentApiDotnet.Entities.Models;

namespace PaymentApiDotnet.Repository
{
    public class BinRepository : IBinRepository
    {
        private readonly DataContext _dataContext;
        public BinRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Bin? GetBankInfosByCardNumber(string cardNumber)
        {
            int binNumber = int.Parse(cardNumber.Substring(0, 6));
            return !string.IsNullOrEmpty(cardNumber) ? (from bin in _dataContext.Bins
                                                        where bin.BinNumber == binNumber
                                                        select bin).FirstOrDefault() : null;
        }

     
    }
}
