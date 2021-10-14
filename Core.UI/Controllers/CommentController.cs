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
    public class CommentController : Controller
    {

        CommentManager commentManager = new CommentManager(new EfCommentDal());

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddCommentPartialView()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlogPartialView(int id)
        {
            var values = commentManager.GetAll(id);
            return PartialView(values);
        }
    }
}
