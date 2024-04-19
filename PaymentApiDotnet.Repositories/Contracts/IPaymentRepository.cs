using PaymentApiDotnet.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repositories.Contracts
{
    public interface IPaymentRepository : IRepositoryBase<PaymentTransaction>
    {
        IQueryable<PaymentTransaction> GetAllPaymentTransactions(bool trackChanges);
        IQueryable<PaymentTransaction> GetPaymentTransactionsByBankCode(int bankCode , bool trackChanges);
        void AddTransaction(PaymentTransaction paymentTransaction);
        void UpdateTransaction(PaymentTransaction paymentTransaction);
        void DeleteTransaction(PaymentTransaction paymentTransaction);
    }
}
