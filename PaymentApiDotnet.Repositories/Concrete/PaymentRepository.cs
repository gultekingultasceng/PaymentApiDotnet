using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Repositories.Contracts;
using PaymentApiDotnet.Repositories.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repositories.Concrete
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public PaymentRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public void AddTransaction(PaymentTransaction payment)
        {
            _repositoryContext.PaymentTransactions.Add(payment);
            _repositoryContext.SaveChanges();
        }
        public List<PaymentTransaction> GetTransactionsByBankCode(int bankCode)
        {
            return _repositoryContext.PaymentTransactions
               .Where(p => p.BankCode.Equals(bankCode))
               .ToList();
        }
    }
}
