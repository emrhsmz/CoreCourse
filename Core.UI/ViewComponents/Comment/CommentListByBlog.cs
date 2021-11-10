using System;
using Core.Business.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core.UI.ViewComponents.Comment
{
    public class CommentListByBlog: ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.GetAll(id);
            return View(values);
        }
    }
}
