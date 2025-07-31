using Abby_WebApp.Data;
using Abby_WebApp.DataAccess.Respositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abby_WebApp.DataAccess.Respositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        internal DbSet <T> dbSet;
        // This constructor can be used to initialize any dependencies or configurations
        // for the repository, such as a database context or logging service.
        // For now, it only initializes the _dbContext field with the provided ApplicationDbContext instance.
        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            dbSet = _dbContext.Set<T>();

        }
        public void Add(T entity)
        {
             dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;    
            return query.ToList();
        }

        public T GetFirstorOrDefault(Expression<Func<T, bool>>? filter = null)
        {
            
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            // If the filter is provided, it applies the filter to the query.
            // If no filter is provided, it returns the entire set.
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
       
    }
}
