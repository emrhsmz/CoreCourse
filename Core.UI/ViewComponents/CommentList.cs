using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.UI.Models;

namespace Core.UI.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName = "Emrah"
                },
                new UserComment
                {
                    Id=2,
                    UserName="Şeyma"
                },
                new UserComment
                {
                    Id=3,
                    UserName="Kerem"
                }
            };
            return View(commentValues);
        }
    }
}
