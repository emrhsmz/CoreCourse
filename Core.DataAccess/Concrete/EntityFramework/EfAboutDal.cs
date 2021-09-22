using Core.DataAccess.Abstract;
using Core.DataAccess.Repositories;
using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal

    {
    }
}
