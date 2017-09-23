using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace beloArte.UI.Controllers.Feedback
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult EnviarOpniao()
        {
            return View();
        }
    }
}