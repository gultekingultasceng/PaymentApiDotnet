using PaymentApiDotnet.Models;
using System.Threading.Tasks;
namespace PaymentApiDotnet.Repository
{
    public interface IPaymentRepository
    {
        Task AddTransaction(PaymentTransaction payment);
    }
}
