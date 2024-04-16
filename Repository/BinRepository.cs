using PaymentApiDotnet.Context;
using PaymentApiDotnet.Models;

namespace PaymentApiDotnet.Repository
{
    public class BinRepository : IBinRepository
    {
        private readonly DataContext _dataContext;
        public BinRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Bin GetBankInfosByCardNumber(string cardNumber)
        {
            int binNumber = int.Parse(cardNumber.Substring(0, 6));
            var binInfo = _dataContext.Bins.FirstOrDefault(pt => pt.BinNumber == binNumber); // FirstOrDefaultAsync yerine FirstOrDefault kullanılır.
            return binInfo;
        }
    }
}
