using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete.EntityFramework.Context;
using Core.DataAccess.Repositories;
using Core.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using(var _context = new CoreDbContext())
            {
                return _context.Blogs.Include(c => c.Category).ToList();
            }
        }
    }
}
