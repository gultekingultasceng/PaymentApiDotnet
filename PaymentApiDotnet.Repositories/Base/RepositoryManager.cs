using PaymentApiDotnet.Repositories.Concrete;
using PaymentApiDotnet.Repositories.Contracts;
using PaymentApiDotnet.Repositories.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repositories.Base
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        #region LAZY LOADINGS
        private readonly Lazy<IPaymentRepository> _paymentRepository;
        private readonly Lazy<IBinRepository> _binRepository;
        #endregion

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _paymentRepository = new Lazy<IPaymentRepository>(() => new PaymentRepository(_repositoryContext));
            _binRepository = new Lazy<IBinRepository>(() => new BinRepository(_repositoryContext));
        }
        public IPaymentRepository paymentRepository => _paymentRepository.Value;

        public IBinRepository binRepository => _binRepository.Value;

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
