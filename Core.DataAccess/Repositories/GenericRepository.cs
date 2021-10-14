using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
            }
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public void Update(T entity)
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
