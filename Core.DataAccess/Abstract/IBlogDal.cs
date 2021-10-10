using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IBlogDal : IGenericRepository<Blog>
    {
        List<Blog> GetListWithCategory();
    }
}
