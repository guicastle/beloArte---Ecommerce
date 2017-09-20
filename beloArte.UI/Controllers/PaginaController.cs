using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace beloArte.UI.Controllers
{
    public class PaginaController : Controller
    {
        // GET: Home
        public ActionResult Principal()
        {
            return View("Index");
        }
    }
}