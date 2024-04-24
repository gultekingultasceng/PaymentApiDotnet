using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IPaymentRepository PaymentRepository { get; }
        IBinRepository BinRepository { get; }
        void Save();
    }
}
