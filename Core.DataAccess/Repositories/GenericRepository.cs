using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<T> GetAll()
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                return context.Set<T>().Find(id);
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
