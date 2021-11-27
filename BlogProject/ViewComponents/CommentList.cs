using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var commentvalues = new List<CommentUser>
            {
                new CommentUser
                {
                    Id =1,
                    UserName = "İsmail"
                },
                new CommentUser
                {
                    Id =2,
                    UserName = "Hakan"
                },
                new CommentUser
                {
                    Id =3,
                    UserName = "Oğuzhan"
                }
            };
            return View(commentvalues);
        }
    }
}
