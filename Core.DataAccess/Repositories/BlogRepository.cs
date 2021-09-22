using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Context;
using Core.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void Add(Blog blog)
        {
            using (CoreDbContext context = new CoreDbContext())
            {
                var added = context.Entry(blog);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Blog> AllList()
        {
            using var db = new CoreDbContext();
            return db.Blogs.ToList();
        }

        public void Delete(Blog blog)
        {
            using var db = new CoreDbContext();
            db.Remove(blog);
            db.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            using var db = new CoreDbContext();
            return db.Blogs.Find(id);
        }

        public void Update(Blog blog)
        {
            using var db = new CoreDbContext();
            db.Update(blog);
            db.SaveChanges();
        }
    }
}
