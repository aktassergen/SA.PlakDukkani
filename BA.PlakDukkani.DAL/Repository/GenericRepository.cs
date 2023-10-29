using BA.PlakDukkani.DAL.Abstract;
using BA.PlakDukkani.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.DAL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private DbContext _dbContext;
        private DbSet<T> _dbSet;
        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
            
        }

        private int DatabaseSave()=> _dbContext.SaveChanges();
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            DatabaseSave();
            
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            DatabaseSave();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetbyId(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            var OldData = _dbSet.Find(entity.Id);
            OldData = entity;
            DatabaseSave();
            
        }
        public IQueryable<T> GetQueryable() => _dbSet.AsQueryable<T>();
    }
    
    
}
