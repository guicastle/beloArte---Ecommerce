using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace beloArte.UI.Controllers.Produto
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Catalago()
        {
            return View("Produto");
        }
    }
}