using smart_crm.core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace smart_crm.core.Interfaces
{
    public interface IAsyncRepository<T> where T : Entity
    {
        T GetByIdAsync(Expression<Func<T, bool>> condition);
        ICollection<T> ListAll();
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);

    }
}
