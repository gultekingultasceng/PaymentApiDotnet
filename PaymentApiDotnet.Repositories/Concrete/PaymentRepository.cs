using PaymentApiDotnet.Entities.Models;
using PaymentApiDotnet.Repositories.Base;
using PaymentApiDotnet.Repositories.Contracts;
using PaymentApiDotnet.Repositories.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repositories.Concrete
{
    public class PaymentRepository : RepositoryBase<PaymentTransaction> , IPaymentRepository
    {
        public PaymentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void AddTransaction(PaymentTransaction paymentTransaction)
        {
            Create(paymentTransaction);
        }

        public void DeleteTransaction(PaymentTransaction paymentTransaction)
        {
            Delete(paymentTransaction);
        }

        public IQueryable<PaymentTransaction> GetAllPaymentTransactions(bool trackChanges)
        {
            return FindAll(trackChanges);
            // we can modify the query exp : FindAll(trackChanges).OrderBy(p => p.Id)
        }

        public IQueryable<PaymentTransaction> GetPaymentTransactionsByBankCode(int bankCode, bool trackChanges)
        {
            return FindByCondition(p => p.BankCode.Equals(bankCode), trackChanges);
        }

        public void UpdateTransaction(PaymentTransaction paymentTransaction)
        {
            Update(paymentTransaction);
        }
    }
}
