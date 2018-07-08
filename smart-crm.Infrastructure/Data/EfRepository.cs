using smart_crm.core.Interfaces;
using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;

namespace smart_crm.Infrastructure.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T : Entity
    {
        private DbContext _dbContext;
        private DbSet<T> _targetTable;

        protected EfRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            this._targetTable = _dbContext.Set<T>();
        }

        public bool Create(T entity)
        {
            _targetTable.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<T> ListAll()
        {
            return _targetTable.ToList();
        }
        public T GetByIdAsync(Expression<Func<T, bool>> condition)
        {
            return (T)_targetTable.FirstOrDefault(condition);
        }

        public bool Update(T entity)
        {
            _targetTable.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            _targetTable.Remove(entity);
            return _dbContext.SaveChanges() > 0;
        }


    }
}