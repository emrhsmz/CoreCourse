using System;
using Core.Business.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.UI.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        public IViewComponentResult Invoke()
        {
            var values = categoryManager.GetAll();
            return View(values);
        }
    }
}
