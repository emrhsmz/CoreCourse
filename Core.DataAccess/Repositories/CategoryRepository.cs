using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Context;
using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        CoreDbContext db = new CoreDbContext();
        public void Add(Category category)
        {
            db.Add(category);
            db.SaveChanges();
        }

        public List<Category> AllList()
        {
            return db.Categories.ToList();
        }

        public void Delete(Category category)
        {
            db.Remove(category);
            db.SaveChanges();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return db.Categories.Find(id);
        }

        public void Update(Category category)
        {
            db.Update(category);
            db.SaveChanges();
        }
    }
}
