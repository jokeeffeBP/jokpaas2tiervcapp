using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace JOK_PaaS_2Tier_VC_App.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
