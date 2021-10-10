using System;
using System.Collections.Generic;
using Core.Entity.Concrete;

namespace Core.Business.Abstract
{
    public interface IBlogService
    {
        void Add(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);
        List<Blog> GetAll();
        Blog GetById(int id);
        List<Blog> GetListWithCategory();
    }
}
