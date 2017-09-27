using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace beloArte.UI.Controllers.Checkout
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult PassosFinais()
        {
            return View();
        }
    }
}