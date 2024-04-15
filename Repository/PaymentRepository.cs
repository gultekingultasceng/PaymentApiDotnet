using Microsoft.EntityFrameworkCore;
using PaymentApiDotnet.Context;
using PaymentApiDotnet.Models;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DataContext _dataContext;
        public PaymentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void AddTransaction(PaymentTransaction payment)
        {
             _dataContext.PaymentTransactions.Add(payment);
             _dataContext.SaveChanges();
        }

        public Bin GetBankInfosByCardNumber(string cardNumber)
        {
            int binNumber = int.Parse(cardNumber.Substring(0, 6));
            var binInfo = _dataContext.Bins.FirstOrDefault(pt => pt.BinNumber == binNumber); // FirstOrDefaultAsync yerine FirstOrDefault kullanılır.
            return binInfo;
        }
    }
}
