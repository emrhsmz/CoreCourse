using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Business.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core.UI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        
        public IActionResult Index()
        {
            var values = blogManager.GetListWithCategory();
            return View(values);
        }
    }
}
