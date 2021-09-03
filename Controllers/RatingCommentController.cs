using RateLimitWebApplication.Models;
using RateLimitWebApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RateLimitWebApplication.Controllers
{
    public class RatingCommentController : Controller
    {

        private RateLimitDBEntities db = new RateLimitDBEntities();

        // GET: RatingComment
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Rating()
        {
            IEnumerable<ArticalViewModel> listmodel = (from obj in db.Artical_Tbl
                            select new ArticalViewModel()
                            {
                               ArticalId=obj.ArticalId,
                               ArticalName=obj.ArticalName,
                               ArticalDescription=obj.ArticalDescription,

                            }).ToList();
                       
                      return View(listmodel);
        }

        public ActionResult ShowComment(int articalId)
        {
            IEnumerable<CommentViewModel> Comentmodel = (from com in db.Comment_Tbl 
                                    where com.ArticalId==articalId
                                    select new CommentViewModel()
                                    {
                                    ArticalId=com.ArticalId,
                                    CommentDescription=com.CommentDescription,
                                    CommentId=com.CommentId,
                                    CommentOn=com.CommentOn,
                                    Rating=com.Rating,

                                    }).ToList();
            return View(Comentmodel);
        }
    }
}