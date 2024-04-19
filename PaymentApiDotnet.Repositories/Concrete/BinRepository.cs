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
    public class BinRepository : IBinRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public BinRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public Bin? GetBankInfosByCardNumber(string cardNumber)
        {
            int binNumber = int.Parse(cardNumber.Substring(0, 6));
            return !string.IsNullOrEmpty(cardNumber) ? (from bin in _repositoryContext.Bins
                                                        where bin.BinNumber == binNumber
                                                        select bin).FirstOrDefault() : null;
        }
    }
}
