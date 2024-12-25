using Entitites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T> where T: BaseEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T? Get(int id);
        IEnumerable<T> GetAll();
    }
}
