using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RateLimitWebApplication.Controllers
{
    public class RateLimitController : Controller
    {
        [RateLimit(Seconds = 10)]
        public ActionResult Index()
        {
            return View();
        }
    }
}