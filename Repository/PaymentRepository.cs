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


    }
}
