using BA.PlakDukkani.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.BLL.Services
{
    public interface IService<T> where T : class,IEntity
    {
        T? GetbyId(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        public IQueryable<T> GetQueryable();

    }
}
