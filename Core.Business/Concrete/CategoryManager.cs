﻿using Core.Business.Abstract;
using Core.DataAccess.Concrete.EntityFramework;
using Core.DataAccess.Repositories;
using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryDal _efCategoryDal;
        public CategoryManager()
        {
            _efCategoryDal = new EfCategoryDal();
        }
        public void Add(Category category)
        {
            _efCategoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _efCategoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _efCategoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _efCategoryDal.GetById(id);
        }

        public void Update(Category category)
        {
            _efCategoryDal.Update(category);
        }
    }
}