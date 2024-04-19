using PaymentApiDotnet.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repositories.Contracts
{
    public interface IPaymentRepository
    {
        void AddTransaction(PaymentTransaction payment);
        public List<PaymentTransaction> GetTransactionsByBankCode(int bankCode);
    }
}
