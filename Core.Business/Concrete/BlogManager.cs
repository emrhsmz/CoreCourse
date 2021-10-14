using System;
using System.Collections.Generic;
using Core.Business.Abstract;
using Core.DataAccess.Abstract;
using Core.Entity.Concrete;

namespace Core.Business.Concrete
{
    public class BlogManager:IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(x => x.Id == id);
        }

        public List<Blog> GetListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
