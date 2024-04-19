using Microsoft.EntityFrameworkCore;
using PaymentApiDotnet.Repositories.Contracts;
using PaymentApiDotnet.Repositories.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApiDotnet.Repositories.Base
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T:class
    {
        protected readonly RepositoryContext _repositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext) 
        {
            _repositoryContext = repositoryContext;
        }
        public void Create(T Entity) => _repositoryContext.Set<T>().Add(Entity);

        public void Delete(T Entity) => _repositoryContext.Set<T>().Remove(Entity);
        public void Update(T Entity) => _repositoryContext.Set<T>().Update(Entity);

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return !trackChanges 
                ? _repositoryContext.Set<T>().AsNoTracking() 
                : _repositoryContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return !trackChanges 
                ? _repositoryContext.Set<T>().Where(expression).AsNoTracking() 
                : _repositoryContext.Set<T>().Where(expression);
        }

       

    }
}
