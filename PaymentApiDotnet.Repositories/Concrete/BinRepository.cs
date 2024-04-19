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
    public class BinRepository :RepositoryBase<Bin>, IBinRepository
    {
        public BinRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public Bin? GetBankInfoByCardNumber(string cardNumber, bool trackChanges)
        {
            int binNumber = int.Parse(cardNumber[..6]);// get first 6 digits as binNumber
            var bin = FindByCondition(b => b.BinNumber.Equals(binNumber), trackChanges).SingleOrDefault();
            return bin;
        }

    
    }
}
