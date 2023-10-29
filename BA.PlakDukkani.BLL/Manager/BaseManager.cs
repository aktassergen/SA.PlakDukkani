using BA.PlakDukkani.BLL.Services;
using BA.PlakDukkani.DAL.Repository;
using BA.PlakDukkani.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.BLL.Manager
{
    public abstract class BaseManager<T> : IService<T> where T : class, IEntity
    {
        GenericRepository<T> _repository;
        public BaseManager(GenericRepository<T> repository)
        {
            _repository = repository;
            
        }
        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public List<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T? GetbyId(int id)
        {
            return _repository.GetbyId(id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
        public IQueryable<T> GetQueryable() => _repository.GetQueryable();
    }
}
