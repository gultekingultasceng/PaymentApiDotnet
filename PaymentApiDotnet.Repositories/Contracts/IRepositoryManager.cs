using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IPaymentRepository paymentRepository { get; }
        IBinRepository binRepository { get; }
        void Save();
    }
}
